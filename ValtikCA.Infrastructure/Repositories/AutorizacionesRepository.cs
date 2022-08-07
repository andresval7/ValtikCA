using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class AutorizacionesRepository : IAutorizacionesRepository
    {
        private DBTiendaValtikContext _context;
        public AutorizacionesRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<Autorizaciones> GetAutorizacion()
        {
            return _context.Autorizaciones;
        }

        public Autorizaciones GetAutorizacionByUser(string user)
        {
            var userExistente = _context.Autorizaciones.
                FirstOrDefault(x => x.UserName.Equals(user));

            return userExistente;

        }

        public void InsertAutorizacionById(Autorizaciones autorizacion)
        {
            _context.Autorizaciones.Add(autorizacion);
            _context.SaveChanges();
        }

        public void UpdateAutorizacionById(Autorizaciones autorizacion)
        {
            var autorizacionExistente = _context.Autorizaciones
                .FirstOrDefault(x => x.UserName.Equals(autorizacion.UserName));
            if (autorizacionExistente != null)
            {
                autorizacionExistente.PasswordAuth = autorizacion.PasswordAuth;
                _context.SaveChanges();
            }

        }

        public void DeleteAutorizacionByUser(string user)
        {
            var autorizacionExistente = _context.Autorizaciones
                .FirstOrDefault(x => x.UserName.Equals(user));
            if (autorizacionExistente != null)
            {
                _context.Remove(autorizacionExistente);
                _context.SaveChanges();
            }

        }
    }
}
