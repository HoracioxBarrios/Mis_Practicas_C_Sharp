using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Biblioteca
{
    public class ApiService
    {
        private string baseUrl = "https://pokeapi.co/api/v2/";
        public ApiService() { }

        public async Task<T> GetData<T>(string namePokemon)
        {
            string endpoint = $"{baseUrl}/pokemon/{namePokemon}";

            T data = default(T);


            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        data = JsonConvert.DeserializeObject<T>(json);
                    }
                    else
                    {
                        // Manejo de errores si la solicitud no es exitosa
                        Console.WriteLine("Error en la solicitud: " + response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones en caso de error en la solicitud
                    Console.WriteLine("Error en la solicitud: " + ex.Message);
                }
            }


                return data;
        }

    }
}