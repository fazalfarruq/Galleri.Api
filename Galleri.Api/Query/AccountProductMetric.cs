using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galleri.Api.Type;
using Galleri.Api.Types.Interfaces;
using Galleri.Api.Types.Models;
using Galleri.Api.Types.Models.GraphQL;
using GraphQL.Types;

namespace Galleri.Api.Query
{
    public class AccountProductMetric : ObjectGraphType
    {
        private readonly IAppSettings _appSettings;

        public AccountProductMetric(IMetricProvider<AccountProductModel> metricProviderService, IAppSettings appSettings)
        {
            _appSettings = appSettings;
            Field<ListGraphType<AccountProduct>>("accountProducts", resolve: context => metricProviderService.GetAll(_appSettings.AccountProductMetricEndpoint));
        }
    }
}
