using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galleri.Api.Types.Interfaces;
using Galleri.Api.Types.Models;

namespace Galleri.Api.Services
{
    public class MetricProviderService<T> : IMetricProvider<T>
    {
        private readonly IHttpClientService _httpClientService;

        public MetricProviderService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<IEnumerable<T>> GetAll(string requestUri)
        {
            var result = await _httpClientService
                .Get<IEnumerable<T>>(requestUri);
            return result;
        }
    }
}
