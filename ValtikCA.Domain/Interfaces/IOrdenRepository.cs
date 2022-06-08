using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Domain.Interfaces
{
    public interface IOrdenRepository
    {
        public IEnumerable<Orden> GetOrden();
        public Orden GetOrdenById(int Id);
        public void InsertOrdenById(Orden orden);
        public void UpdateOrdenById(Orden orden);
        public void DeleteOrdenById(Orden orden);

    }
}
