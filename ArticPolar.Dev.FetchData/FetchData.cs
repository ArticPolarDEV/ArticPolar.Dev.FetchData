using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ArticPolar.Dev.FetchData
{
    public class FetchData
    {
        private readonly HttpClient httpClient;

        public FetchData()
        {
            httpClient = new HttpClient();
        }

        public string Fetch(string apiUrl)
        {
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    return data;
                }
                else
                {
                    // Em caso de erro, você pode tratar aqui de acordo com suas necessidades.
                    MessageBox.Show($"Erro na solicitação HTTP GET: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Trate exceções, se necessário.
                MessageBox.Show($"Erro na solicitação HTTP GET: {ex.Message}");
                return null;
            }
        }

        public string PostData(string apiUrl, string content)
        {
            try
            {
                var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(apiUrl, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;
                    return responseData;
                }
                else
                {
                    // Em caso de erro, você pode tratar aqui de acordo com suas necessidades.
                    Console.WriteLine($"Erro na solicitação HTTP POST: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Trate exceções, se necessário.
                Console.WriteLine($"Erro na solicitação HTTP POST: {ex.Message}");
                return null;
            }
        }
    }
}
