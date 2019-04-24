using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Synology.TestWebApplication.Classes;
using IOFile = System.IO.File;

namespace Synology.TestWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public string SynologyHost { get; set; }
        public int SynologyPort { get; set; }
        public string SynologyUser { get; set; }
        public string SynologyPass { get; set; }
        public bool UseSsl { get; set; }

        public IActionResult OnGet()
        {
            if (!IOFile.Exists("synosettings.json"))
            {
                return RedirectToPage("Settings");
            }

            var settings = JsonConvert.DeserializeObject<SettingsData>(IOFile.ReadAllText("synosettings.json"));

            SynologyHost = settings.SynologyHost;
            SynologyPort = settings.SynologyPort;
            SynologyUser = settings.SynologyUser;
            SynologyPass = settings.SynologyPass;
            UseSsl = settings.UseSsl;

            return Page();
        }
    }
}
