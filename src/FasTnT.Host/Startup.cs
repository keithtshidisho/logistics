﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FasTnT.Persistence.Dapper;
using FasTnT.Host.Middleware;
using FasTnT.Host.BackgroundTasks;
using FasTnT.Domain.Extensions;
using FasTnT.Domain;
using Microsoft.Extensions.Hosting;
using FasTnT.Host.Infrastructure.Binding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using FasTnT.Formatters.Json;
using Microsoft.AspNetCore.Mvc;
using FasTnT.Host.Infrastructure;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FasTnT.Host
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets(GetType().Assembly);
            }

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEpcisDomain()
                    .AddEpcisPersistence(Configuration.GetConnectionString("FasTnT.Database"))
                    .AddSingleton<IHostedService, SubscriptionService>()
                    .AddSingleton(new FormatterProvider(new IFormatterFactory[] { new JsonFormatterFactory(), new XmlFormatterFactory(), new SoapFormatterFactory() }));

            services.AddMvc(o =>
                    {
                        o.ModelBinderProviders.Insert(0, new AbstractModelBinderProvider());
                        o.InputFormatters.Insert(0, new QueryParameterInputFormatter());
                        o.InputFormatters.Insert(0, new EpcisRequestInputFormatter());
                        o.OutputFormatters.Insert(0, new EpcisResponseOutputFormatter());
                    })
                    .AddApplicationPart(typeof(Startup).Assembly).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddApiVersioning();
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Constants.SubscriptionTaskDelayTimeoutInMs = Configuration.GetSection("Settings").GetValue("SubscriptionWaitTimeout", 5000);

            app.UseExceptionHandlingMiddleware(env.IsDevelopment())
               .UseAuthentication()
               .UseNoContentStatusCode()
               .UseMvc();
        }
    }
}
