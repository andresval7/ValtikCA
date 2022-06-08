using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Domain.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> GetCliente();
        public Cliente GetClienteById(decimal Id);
        public void InsertClienteById(Cliente cliente);
        public void UpdateClienteById(Cliente cliente);
        public void DeleteClienteById(Cliente cliente);
    }
}
