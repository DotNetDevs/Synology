using System;
using Microsoft.Extensions.DependencyInjection;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Settings;
using Synology.Utilities;

namespace Synology
{
    public static class LoggingServiceCollectionExtensions
    {
        //
        // Static Methods
        //
        public static IServiceCollection AddSynology(this IServiceCollection services)
        {
            return AddSynology(services, b => b.AddApi().AddAudioStation().AddDownloadStation().AddDownloadStation2().AddFileStation().AddSurveillanceStation().AddVideoStation());
        }

        public static IServiceCollection AddSynology(this IServiceCollection services, Action<ISynologyBuilder> configure)
        {
            if (configure == null) throw new ArgumentNullException(nameof(configure));

            services.AddOptions();
            services.AddSingleton<ISynologyConnectionSettings, SynologyConnectionSettings>();
            services.AddSingleton<SidContainer, SidContainer>();
            services.AddTransient<ISynologyConnection, SynologyConnection>();

            configure(new SynologyBuilder(services));

            return services;
        }
    }
}
