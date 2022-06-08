using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class OrdenRepository : IOrdenRepository
    {
        private DBTiendaValtikContext _context;
        public OrdenRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<Orden> GetOrden()
        {
            return _context.TblOrdenes;
        }

        public Orden GetOrdenById(int Id)
        {
            var ordenExistente = _context.TblOrdenes.
                FirstOrDefault(x => x.IdOrden == (Id));

            return ordenExistente;

        }

        public void InsertOrdenById(Orden orden)
        {
            _context.TblOrdenes.Add(orden);
            _context.SaveChanges();
        }

        public void UpdateOrdenById(Orden orden)
        {
            var ordenExistente = _context.TblOrdenes
                .FirstOrDefault(x => x.IdOrden == (orden.IdOrden));
            if (ordenExistente != null)
            {
                ordenExistente.IdCliente = orden.IdCliente;
                ordenExistente.Cantidad = orden.Cantidad;
                ordenExistente.DireccionEnvio = orden.DireccionEnvio;
                ordenExistente.FechaOrden = orden.FechaOrden;
                ordenExistente.EstadoOrden = orden.EstadoOrden;
                
                _context.SaveChanges();
            }

        }

        public void DeleteOrdenById(Orden orden)
        {
            var ordenExistente = _context.TblOrdenes
                .FirstOrDefault(x => x.IdOrden == (orden.IdOrden));
            if (ordenExistente != null)
            {
                _context.Remove(ordenExistente);
                _context.SaveChanges();
            }

        }
    }
}
