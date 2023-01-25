using Newtonsoft.Json;

namespace consumindo_api.Models
{
    public class EnderecoServices
    {
        public async Task<Endereco> ConsumirAPI(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{id}/json/");
            var jsonString = await response.Content.ReadAsStringAsync();

            var jsonObject = JsonConvert.DeserializeObject<Endereco>(jsonString);

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                new Endereco
                {
                    Verificacao = true
                };
            }

            return jsonObject;
        }
    }
}