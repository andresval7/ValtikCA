using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> GetCliente();
        public Cliente GetClienteById(decimal Id);
        public void InsertClienteById(Cliente cliente);
        public void UpdateClienteById(Cliente cliente);
        public void DeleteClienteById(decimal cliente);
    }
}
