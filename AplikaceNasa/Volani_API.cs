using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AplikaceNasa
{
    public class Volani_API
    {
        public static async Task<API_Data> 
            Get(string odkaz)
        {
            using (var http = new HttpClient())
            {
                var request = await http.GetAsync(odkaz);

                if (request.IsSuccessStatusCode)
                {
                    return new API_Data { Data = await request.Content.ReadAsStringAsync() };
                }
                else
                    return null;
            }
        }
    }

    public class API_Data
    {
        public string Data { get; set; }
    }
}