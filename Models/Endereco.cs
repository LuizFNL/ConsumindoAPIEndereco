using System;
using Newtonsoft.Json;

namespace consumindo_api.Models
{
    public class Endereco
    {
        [JsonProperty("cep")]
        public string Cep;

        [JsonProperty("logradouro")]
        public string Logradouro;

        [JsonProperty("complemento")]
        public string Complemento;

        [JsonProperty("bairro")]
        public string Bairro;

        [JsonProperty("localidade")]
        public string Localidade;

        [JsonProperty("uf")]
        public string Uf;

        [JsonProperty("ibge")]
        public string Ibge;

        [JsonProperty("gia")]
        public string Gia;

        [JsonProperty("ddd")]
        public string Ddd;

        [JsonProperty("siafi")]
        public string Siafi;

        public bool Verificacao = false;
    }
}