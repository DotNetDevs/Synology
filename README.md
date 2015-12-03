# Synology

The following code is my test project, you can use it as a guide for now. I will write the documentation, I promise.

```
using (var syno = new SynologyConnection(LoginData.Url, true))
{
	Console.WriteLine("Info");
	var resInfo = syno.Api().Info().GetInfo();

	Console.WriteLine(JsonConvert.SerializeObject(resInfo));

	Console.WriteLine("Auth Login");
	var resLogin = syno.Api().Auth().Login(LoginData.Username, LoginData.Password);

	Console.WriteLine(JsonConvert.SerializeObject(resLogin));

	if (resLogin.Error == null || (resLogin.Error != null && resLogin.Error.Code == 403))
	{
		if (resLogin.Error != null && resLogin.Error.Code == 403)
		{
			do
			{
				Console.Write("Otp Code: ");

				var otp = Console.ReadLine();

				resLogin = syno.Api().Auth().Login(LoginData.Username, LoginData.Password, otp);

				Console.WriteLine(JsonConvert.SerializeObject(resLogin));
			}
			while (resLogin.Error != null && resLogin.Error.Code == 404);
		}

		if (resLogin.Error == null)
		{
			Console.WriteLine("DS Info");
			var dsResInfo = syno.DownloadStation().Info().GetInfo();
			Console.WriteLine(JsonConvert.SerializeObject(dsResInfo));

			Console.WriteLine("DS Config");
			var dsResConfig = syno.DownloadStation().Info().Config();
			Console.WriteLine(JsonConvert.SerializeObject(dsResConfig));

			Console.WriteLine("DS Schedule Config");
			var dsResSchedule = syno.DownloadStation().Schedule().Config();
			Console.WriteLine(JsonConvert.SerializeObject(dsResSchedule));

			Console.WriteLine("DS Task List");
			var dsResTasks = syno.DownloadStation().Task().List(TaskDetailsType.Detail | TaskDetailsType.Transfer | TaskDetailsType.File | TaskDetailsType.Tracker | TaskDetailsType.Peer);
			Console.WriteLine(JsonConvert.SerializeObject(dsResTasks));

			Console.WriteLine("FS Info");
			var fsResInfo = syno.FileStation().Info().GetInfo();
			Console.WriteLine(JsonConvert.SerializeObject(fsResInfo));

			Console.WriteLine("FS List Share");
			var fsResShares = syno.FileStation().FileShare().ListShare("real_path,owner,time,perm,mount_point_type,sync_share,volume_status");
			Console.WriteLine(JsonConvert.SerializeObject(fsResShares));

			Console.WriteLine("FS List");
			var fsResList = syno.FileStation().FileShare().List("/downloads", null, "all", null, "real_path,size,owner,time,perm,type,mount_point_type");
			Console.WriteLine(JsonConvert.SerializeObject(fsResList));

			Console.WriteLine("FS Info");
			var fsResFileInfo = syno.FileStation().FileShare().Info("/downloads/.apdisk", "real_path,size,owner,time,perm,type,mount_point_type");
			Console.WriteLine(JsonConvert.SerializeObject(fsResFileInfo));

			Console.WriteLine("Auth Logout");
			var resLogout = syno.Api().Auth().Logout();
			Console.WriteLine(JsonConvert.SerializeObject(resLogout));
		}
	}
}
```
