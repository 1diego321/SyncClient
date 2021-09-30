using Newtonsoft.Json;
using SyncClient.Core.Models.Reponse;
using System.Net.Http;
using System.Text;

namespace SyncClient.Core.HTTP
{
    public class HttpRepository
    {
        public SyncResponse Send(object data, string url)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                using (var httpClient = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(data);

                    request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                    request.Headers.Add("X-Sync-Authorization", "wc789w#98a%8apw$d87a$b&78awg#dbp&8awvd");

                    using (var response = httpClient.Send(request))
                    {
                        var result = new SyncResponse();

                        if(response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            result = JsonConvert.DeserializeObject<SyncResponse>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        }
                        else
                        {
                            result.Success = false;
                        }

                        result.StatusCode = response.StatusCode;

                        return result;
                    }
                }
            }
        }
    }
}
