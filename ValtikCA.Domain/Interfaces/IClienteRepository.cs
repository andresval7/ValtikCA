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
        public IEnumerable<TblCliente> GetCliente();
        public TblCliente GetClienteById(decimal Id);
        public void InsertClienteById(TblCliente cliente);
        public void UpdateClienteById(TblCliente cliente);
        public void DeleteClienteById(TblCliente cliente);
    }
}
