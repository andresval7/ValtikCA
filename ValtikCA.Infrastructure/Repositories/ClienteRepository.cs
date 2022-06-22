using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DBTiendaValtikContext _context;
        public ClienteRepository (DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetCliente()
        {
            return _context.TblClientes;
        }

        public Cliente GetClienteById(decimal  Id)
        {
            var clienteExistente = _context.TblClientes.
                FirstOrDefault(x => x.IdCliente == Id);

            return clienteExistente;

        }

        public void InsertClienteById(Cliente cliente)
        {
            _context.TblClientes.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateClienteById(Cliente cliente)
        {
            var clienteExistente = _context.TblClientes
                .FirstOrDefault(x => x.IdCliente == cliente.IdCliente);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre1 = cliente.Nombre1;
                clienteExistente.Nombre2 = cliente.Nombre2;
                clienteExistente.Apellido1 = cliente.Apellido1;
                clienteExistente.Apellido2 = cliente.Apellido2;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Password1 = cliente.Password1;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Ciudad = cliente.Ciudad;
                clienteExistente.CodigoPostal = cliente.CodigoPostal;
                clienteExistente.Provincia = cliente.Provincia;
                _context.SaveChanges();
            }

        }

        public void DeleteClienteById(decimal cliente)
        {
            var clienteExistente = _context.TblClientes
                .FirstOrDefault(x => x.IdCliente == cliente);
            if (clienteExistente != null)
            {
                _context.Remove(clienteExistente);
                _context.SaveChanges();
            }

        }
    }
}
