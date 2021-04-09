using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galleri.Api.Query;

namespace Galleri.Api.Schema
{
    public class AccountProductMetricSchema : GraphQL.Types.Schema
    {
        public AccountProductMetricSchema(AccountProductMetric accountProductMetric)
        {
            Query = accountProductMetric;
        }
    }
}
