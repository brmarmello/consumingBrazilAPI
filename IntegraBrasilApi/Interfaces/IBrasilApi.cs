using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosOsBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
