using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galleri.Api.Models;
using GraphQL.Types;

namespace Galleri.Api.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
