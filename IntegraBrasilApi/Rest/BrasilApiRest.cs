using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest
    {
        public Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep)
        {
            throw new NotImplementedException();
        }
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosOsBancos()
        {
            throw new NotImplementedException();
        }
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }
    }
}
