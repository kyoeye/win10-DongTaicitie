using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Documents;

namespace desk.cs.item
{
    class XMLhelper
    {
        //string化xml
        public static async Task<string> Getxmlstring(string url, string formData)
        {
            // fromData为null
            string requestUri = url;

            string resulrt; //用来存储xml转换的string

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(new Uri(requestUri)))
                    {
                        httpResponseMessage.EnsureSuccessStatusCode();
                        var xmltext = await httpResponseMessage.Content.ReadAsStringAsync();
                        resulrt = xmltext;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                resulrt = null;
                throw;
            }
            return resulrt;
        }
    }
}
