using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Dtos
{
    public interface EnderecoResponse
    {
        public string? CEP { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Região { get; set; }
        public string? Rua { get; set; }
        [JsonIgnore]
        public string? Servico { get; set; }
    }
}
