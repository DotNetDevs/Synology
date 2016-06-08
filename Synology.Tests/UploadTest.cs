using Synology.FileStation.Upload.Parameters;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Synology.Classes;
using Synology.Api.Auth.Results;
using Synology.Api.Auth.Parameters;
using Newtonsoft.Json;

namespace Synology.Tests
{
    [TestClass]
    public class UploadTest
    {
        private static string TestHost = "SynologyHost.ddns.net";
        private static dynamic LoginData = new
        {
            Username = "UserName",
            Password = "Password",
            Opt = string.Empty
        };

        [TestMethod]
        public void SuccessUpload()
        {
            var fileData = File.ReadAllBytes("SynologyUploadTestFile.txt");

            using (SynologyConnection connection = new SynologyConnection(TestHost))
            {
                if(!DoConnection(connection))
                {
                    Assert.Fail("The connection to synology server failed.");
                }

                var result = connection.FileStation().Upload().Upload(new UploadParameters
                {
                    DestinationPath = "/temp",
                    Overwrite = true,
                    FileName = "SynologyUploadTestFile.txt",
                    FileData = fileData,
                });
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

                if(resLogin.Error == null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
