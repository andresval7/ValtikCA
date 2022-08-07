using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IAutorizacionesRepository
    {
        public IEnumerable<Autorizaciones> GetAutorizacion();
        public Autorizaciones GetAutorizacionByUser(string user);

        public void InsertAutorizacionById(Autorizaciones autorizacion);
        public void UpdateAutorizacionById(Autorizaciones autorizacion);
        public void DeleteAutorizacionByUser(string user);
    }
}