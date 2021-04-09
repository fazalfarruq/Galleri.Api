using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galleri.Api.Interfaces;
using Galleri.Api.Query;
using Galleri.Api.Schema;
using Galleri.Api.Services;
using Galleri.Api.Type;
using Galleri.Api.Types.Interfaces;
using Galleri.Api.Types.Models;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;

namespace Galleri.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IAppSettings, AppSettings>();
            services.AddTransient<IHttpClientService, HttpClientService>();
            services.AddTransient<IMetricProvider<AccountProductModel>, MetricProviderService<AccountProductModel>>();
            services.AddSingleton<AccountProductMetric>();
            services.AddSingleton<ISchema, AccountProductMetricSchema>();

            services.AddGraphQL(
                options =>
                {
                    options.EnableMetrics = false;
                }).AddSystemTextJson();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}
