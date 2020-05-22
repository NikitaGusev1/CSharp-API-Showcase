using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using GetRequestAndParse;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace GetRequestAndParse
{
    public static class ReqParse
    {
        public static async Task<Rootobject> GetReq()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.icndb.com/jokes");
                using (HttpResponseMessage response = await client.GetAsync(client.BaseAddress))
                {
                    if(response.IsSuccessStatusCode)
                    {
                        {
                            using (HttpContent content = response.Content)
                            {
                                string result = await content.ReadAsStringAsync();
                                var res = JsonConvert.DeserializeObject<Rootobject>(result);
                                //var t = res.value[0].joke.ToString();
                                //var lst = new List<string>();
                                //foreach (var j in res.value)
                                //{
                                //    lst.Add(j.joke);
                                //}
                                return res;

                            }
                            
                        }
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            }
        }
    }
}

