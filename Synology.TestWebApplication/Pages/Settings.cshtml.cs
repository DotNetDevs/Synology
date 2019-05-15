using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Synology.Interfaces;
using Synology.TestWebApplication.Classes;
using IOFile = System.IO.File;

namespace Synology.TestWebApplication.Pages
{
    public class SettingsModel : PageModel
    {
        private readonly IServiceProvider _serviceProvider;

        public SettingsModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [Required]
        [BindProperty]
        public string SynologyHost { get; set; }
        [Required]
        [BindProperty]
        public int SynologyPort { get; set; }
        [Required]
        [BindProperty]
        public string SynologyUser { get; set; }
        [Required]
        [BindProperty]
        public string SynologyPass { get; set; }
        [BindProperty]
        public bool UseSsl { get; set; }

        public void OnGet()
        {
            SettingsData settings = null;

            if (IOFile.Exists("synosettings.json"))
            {
                settings = JsonConvert.DeserializeObject<SettingsData>(IOFile.ReadAllText("synosettings.json"));

                SynologyHost = settings.SynologyHost;
                SynologyPort = settings.SynologyPort;
                SynologyUser = settings.SynologyUser;
                SynologyPass = settings.SynologyPass;
                UseSsl = settings.UseSsl;
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var settings = _serviceProvider.GetService<ISynologyConnectionSettings>();

                settings.BaseHost = SynologyHost;
                settings.Password = SynologyPass;
                settings.Port = SynologyPort;
                settings.Ssl = UseSsl;
                settings.SslPort = SynologyPort;
                settings.Username = SynologyUser;

                using (var syno = _serviceProvider.GetService<ISynologyConnection>())
                {
                    var result = await syno.Api().Auth().LoginAsync();

                    if (!result.Success && result.Error.Code != 403)
                    {
                        ModelState.AddModelError("", "Invalid connection settings.");
                    }
                    else
                    {
                        var json = JsonConvert.SerializeObject(settings, Formatting.Indented);

                        IOFile.WriteAllText("synosettings.json", json);

                        return RedirectToPage("Index");
                    }
                }
            }

            return Page();
        }
    }
}
