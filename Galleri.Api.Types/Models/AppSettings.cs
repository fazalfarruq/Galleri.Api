using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Galleri.Api.Types.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Galleri.Api.Types.Models
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string AccountProductMetricEndpoint 
            => _configuration["Config:AccountProductMetricEndpoint"];
    }
}
