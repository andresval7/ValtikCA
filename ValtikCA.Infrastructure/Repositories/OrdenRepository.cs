using ValtikCA.Domain.Entities;
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
            return _context.Ordenes;
        }

        public Orden GetOrdenById(decimal Id)
        {
            var ordenExistente = _context.Ordenes.
                FirstOrDefault(x => x.IdOrden == Id);

            return ordenExistente;

        }

        public void InsertOrdenById(Orden orden)
        {
            _context.Ordenes.Add(orden);
            _context.SaveChanges();
        }

        public void UpdateOrdenById(Orden orden)
        {
            var ordenExistente = _context.Ordenes
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

        public void DeleteOrdenById(decimal orden)
        {
            var ordenExistente = _context.Ordenes
                .FirstOrDefault(x => x.IdOrden == orden);
            if (ordenExistente != null)
            {
                _context.Remove(ordenExistente);
                _context.SaveChanges();
            }

        }
    }
}
