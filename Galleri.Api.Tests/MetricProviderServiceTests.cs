using System;
using System.Linq;
using Galleri.Api.Models;
using Galleri.Api.Services;
using Galleri.Api.Types.Models;
using Xunit;

namespace Galleri.Api.Tests
{
    public class MetricProviderServiceTests
    {
        [Fact]
        public void MetricProviderService_GetAll_ShouldReturnEntities()
        {
            var url =
                "https://galleri-metric-provider.azurewebsites.net/api/Account_Product_Metric?code=HCSGOE4OO07ra8LQmRl9vtG3WZAhVXBoXfyZsfmN3wCh7TtIdrZE9A==";
            var client = new HttpClientService();
            var service = new MetricProviderService<AccountProductModel>(client);
            var result = service.GetAll(url).Result.ToList();
            Assert.NotEmpty(result);
        }
    }
}
