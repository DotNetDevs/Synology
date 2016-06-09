using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Synology.Api.Auth.Parameters;
using Synology.Classes;
using Synology.Api.Auth.Results;
using System.IO;
using Synology.DownloadStation.TaskEx.Parameters;

namespace Synology.Tests
{
    [TestClass]
    public class DownloadStationTests
    {
        private static string TestHost = "SynologyHost.ddns.net";
        private static string TorrentFile = "AtorrentFileToTest.torrent";
        private static dynamic LoginData = new
        {
            Username = "UserName",
            Password = "Password",
            Opt = string.Empty
        };

        [TestMethod]
        public void CreateExDownloadTest()
        {
            var fileData = File.ReadAllBytes(TorrentFile);

            using (SynologyConnection connection = new SynologyConnection(TestHost))
            {
                if (!DoConnection(connection))
                {
                    Assert.Fail("The connection to synology server failed.");
                }

                var result = connection.DownloadStation().TaskEx().Create(new TaskCreateExParameters
                {
                    Destination = "home/Downloads",
                    Filename = Path.GetFileName(TorrentFile),
                    File = fileData,
                });

                Assert.IsTrue(result.Success, $"The create download failed with error code : {result.Error?.Code}");
                Assert.IsNotNull(result.Data, "The data object is null (check json parsing)");
                Assert.IsNotNull(result.Data.TaskIds, "The task id list object is null (check json parsing)");

                var deleteResult = connection.DownloadStation().Task().Delete(new DownloadStation.Task.Parameters.TaskDeleteParameters
                {
                    Ids = result.Data.TaskIds.ToArray()
                });

                Assert.IsTrue(deleteResult.Success, $"The delete download failed with error code : {deleteResult.Error?.Code}");
            }
        }

        public static void GetOtp(SynologyConnection syno, ref ResultData<AuthResult> resLogin)
        {
            do
            {
                Console.Write("Otp Code: ");

                var otp = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(otp))
                {
                    resLogin.Error = new ResultError { Code = 404 };
                    continue;
                }

                resLogin = syno.Api().Auth().Login(new LoginParameters
                {
                    Username = LoginData.Username,
                    Password = LoginData.Password,
                    OtpCode = otp
                });

                Console.WriteLine(JsonConvert.SerializeObject(resLogin));
            }
            while (resLogin.Error != null && resLogin.Error.Code == 404);
        }

        public static bool DoConnection(SynologyConnection syno)
        {
            Console.WriteLine("Info");
            var resInfo = syno.Api().Info().GetInfo();

            Console.WriteLine(JsonConvert.SerializeObject(resInfo));

            Console.WriteLine("Auth Login");
            var resLogin = syno.Api().Auth().Login(new LoginParameters
            {
                Username = LoginData.Username,
                Password = LoginData.Password
            });

            Console.WriteLine(JsonConvert.SerializeObject(resLogin));

            if (resLogin.Error == null || (resLogin.Error != null && resLogin.Error.Code == 403))
            {
                if (resLogin.Error != null && resLogin.Error.Code == 403)
                {
                    GetOtp(syno, ref resLogin);
                }

                if (resLogin.Error == null)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
