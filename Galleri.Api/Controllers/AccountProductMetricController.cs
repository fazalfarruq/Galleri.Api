using System.Collections.Generic;
using System.Threading.Tasks;
using Galleri.Api.Interfaces;
using Galleri.Api.Models;
using Galleri.Api.Types.Interfaces;
using Galleri.Api.Types.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Galleri.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountProductMetricController : ControllerBase
    {
        private IMetricProvider<AccountProductModel> _metricProvider;
        private readonly IAppSettings _appSettings;

        public AccountProductMetricController(IMetricProvider<AccountProductModel> metricProvider,
            IAppSettings appSettings)
        {
            _metricProvider = metricProvider;
            _appSettings = appSettings;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountProductModel>> Get()
        {
            return await _metricProvider.GetAll(_appSettings.AccountProductMetricEndpoint);
        }
    }
}
