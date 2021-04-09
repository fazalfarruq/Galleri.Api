using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Galleri.Api.Types.Interfaces
{
    public interface IHttpClientService
    {
        Task<T> Get<T>(string requestUri);
    }
}
