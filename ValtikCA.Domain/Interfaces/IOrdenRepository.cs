using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IOrdenRepository
    {
        public IEnumerable<Orden> GetOrden();
        public Orden GetOrdenById(decimal Id);
        public void InsertOrdenById(Orden orden);
        public void UpdateOrdenById(Orden orden);
        public void DeleteOrdenById(decimal orden);

    }
}
