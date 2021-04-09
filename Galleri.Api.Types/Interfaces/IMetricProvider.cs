using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galleri.Api.Types.Interfaces
{
    public interface IMetricProvider<T>
    {
        Task<IEnumerable<T>> GetAll(string requestUri);
    }
}
