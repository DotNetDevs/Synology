using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Synology.Classes;
using Synology.Interfaces;
using Synology.Settings;
using Synology.Utilities;

namespace Synology
{
    /// <summary>
    /// Logging service collection extensions.
    /// </summary>
    public static class LoggingServiceCollectionExtensions
    {
        //
        // Static Methods
        //
        /// <summary>
        /// Adds the Synology classes, with all features.
        /// </summary>
        /// <returns>The synology.</returns>
        /// <param name="services">Services.</param>
        public static IServiceCollection AddSynology(this IServiceCollection services)
        {
            return AddSynology(services, b => b.AddApi().AddAudioStation().AddDownloadStation().AddDownloadStation2().AddFileStation().AddSurveillanceStation().AddVideoStation());
        }

        /// <summary>
        /// Adds the Synology classes, you can choose the features.
        /// </summary>
        /// <returns>The synology.</returns>
        /// <param name="services">Services.</param>
        /// <param name="configure">Configure.</param>
        public static IServiceCollection AddSynology(this IServiceCollection services, Action<ISynologyBuilder> configure)
        {
            if (configure == null) throw new ArgumentNullException(nameof(configure));

            services.AddOptions();
            services.AddScoped<ISynologyConnectionSettings, SynologyConnectionSettings>();
            services.AddScoped<SidContainer>();

            services.AddScoped<HttpClientHandler>();
            services.AddScoped(provider => new HttpClient(provider.GetService<HttpClientHandler>()));
            services.AddScoped<ISynologyConnection, SynologyConnection>(provider => new SynologyConnection(provider.GetService<ISynologyConnectionSettings>(), provider.GetService<SidContainer>(), provider.GetService<ILoggerFactory>(), provider, provider.GetService<HttpClient>(), provider.GetService<HttpClientHandler>()));

            configure(new SynologyBuilder(services));

            return services;
        }

        internal static IServiceCollection AddRequest<TRequestInterface, TRequest>(this IServiceCollection services)
            where TRequestInterface : class, ISynologyRequest
            where TRequest : SynologyRequest, TRequestInterface
        {
            return services.AddTransient<TRequestInterface, TRequest>();
        }

        internal static IServiceCollection AddApi<TApiInterface, TApi>(this IServiceCollection services)
            where TApiInterface : class, ISynologyApi
            where TApi : SynologyApi, TApiInterface
        {
            return services.AddTransient<TApiInterface, TApi>();
        }
    }
}
