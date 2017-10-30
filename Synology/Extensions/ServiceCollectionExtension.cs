﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Settings;

namespace Synology
{
    public static class LoggingServiceCollectionExtensions
    {
        //
        // Static Methods
        //
        public static IServiceCollection AddSynology(this IServiceCollection services)
        {
            return AddSynology(services, t => { });   
        }

        public static IServiceCollection AddSynology(this IServiceCollection services, Action<ISynologyBuilder> configure)
        {
            if (configure == null) throw new ArgumentNullException(nameof(configure));

            services.AddOptions();
            services.AddSingleton<ISynologyConnectionSettings, SynologyConnectionSettings>();
            services.AddSingleton<ISynologyConnection, SynologyConnection>();

            configure(new SynologyBuilder(services));

            return services;
        }
    }
}
