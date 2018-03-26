using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Synology.Interfaces;
using Synology.TestWebApplication.Models;

namespace Synology.TestWebApplication.Controllers
{
    using IOFile = System.IO.File;

    public class HomeController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            if (!IOFile.Exists("synosettings.json")) return RedirectToAction(nameof(Settings));

            var settings = JsonConvert.DeserializeObject<SettingsViewModel>(IOFile.ReadAllText("synosettings.json"));

            return View();
        }

        public IActionResult Settings()
        {
            SettingsViewModel model = null;

            if (IOFile.Exists("synosettings.json"))
                model = JsonConvert.DeserializeObject<SettingsViewModel>(IOFile.ReadAllText("synosettings.json"));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Settings(SettingsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var settings = _serviceProvider.GetService<ISynologyConnectionSettings>();

                settings.BaseHost = model.SynologyHost;
                settings.Password = model.SynologyPass;
                settings.Port = model.SynologyPort;
                settings.Ssl = model.UseSsl;
                settings.SslPort = model.SynologyPort;
                settings.Username = model.SynologyUser;

                using (var syno = _serviceProvider.GetService<ISynologyConnection>())
                {
                    var result = await syno.Api().Auth().LoginAsync();

                    if (!result.Success && result.Error.Code != 403)
                    {
                        ModelState.AddModelError("", "Invalid connection settings.");
                    }
                    else
                    {
                        var json = JsonConvert.SerializeObject(model, Formatting.Indented);

                        IOFile.WriteAllText("synosettings.json", json);

                        return RedirectToAction("Index");
                    }
                }
            }

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
