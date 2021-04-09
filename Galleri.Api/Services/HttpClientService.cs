using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Galleri.Api.Types.Interfaces;
using Newtonsoft.Json;

namespace Galleri.Api.Services
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<T> Get<T>(string requestUri)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var result = await httpClient.GetAsync(requestUri);

                    if (result.IsSuccessStatusCode)
                    {
                        var responseFromServer = await result.Content.ReadAsStringAsync();
                        var response = JsonConvert.DeserializeObject<T>(responseFromServer);
                        return response;
                    }
                }

                return default;
            }
            catch (Exception e)
            {
                return default;
            }
        }
    }
}
