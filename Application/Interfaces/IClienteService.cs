using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Interfaces
{
    public interface IClienteService
    {
        ClienteResponse GetClienteById(decimal Id);
        
        IEnumerable<ClienteResponse> GetCliente();

        void InsertClienteById(CreateClienteRequest cliente);

        void UpdateClienteById(UpdateClienteRequest cliente);

        void DeleteClienteById(decimal Id);
        void InsertClienteById(Cliente cliente);
    }
}
