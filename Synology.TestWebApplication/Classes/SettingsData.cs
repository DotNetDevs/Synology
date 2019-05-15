using System;
namespace Synology.TestWebApplication.Classes
{
    public class SettingsData
    {
        public string SynologyHost { get; set; }
        public int SynologyPort { get; set; }
        public string SynologyUser { get; set; }
        public string SynologyPass { get; set; }
        public bool UseSsl { get; set; }
    }
}
