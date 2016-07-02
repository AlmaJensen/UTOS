using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UTOS.API
{
    public class API
    {
        public async Task<IEnumerable<Talk>> GetSessions()
        {
            IEnumerable<Talk> talks = new List<Talk>();
            var httpcontent = await GetHttpResultStream(DataResources.SessionsURL);
            if (httpcontent != null)
                using (var reader = new JsonTextReader(new StreamReader(httpcontent)))
                    talks = JsonSerializer.Create().Deserialize<Talk[]>(reader);
            if (talks != null)
                return talks;

            return null;
        }
        public async Task<IEnumerable<Sponsor>> GetSponsors()
        {
            IEnumerable<Sponsor> talks = new List<Sponsor>();
            var httpcontent = await GetHttpResultStream(DataResources.SponsorsURL);
            if (httpcontent != null)
                using (var reader = new JsonTextReader(new StreamReader(httpcontent)))
                    talks = JsonSerializer.Create().Deserialize<Sponsor[]>(reader);
            if (talks != null)
                return talks;

            return null;
        }
        protected async Task<Stream> GetHttpResultStream(string url)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                HttpClient client = new HttpClient();
                var result = await client.GetAsync(url);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    return await result.Content.ReadAsStreamAsync();
                else
                    return null;

            }
            else
                return null;
        }
    }
}
