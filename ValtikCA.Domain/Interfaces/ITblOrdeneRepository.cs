using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Domain.Interfaces
{
    public interface ITblOrdeneRepository
    {
        public IEnumerable<TblOrdene> GetOrden();
        public TblOrdene GetOrdenById(int Id);
        public void InsertOrdenById(TblOrdene orden);
        public void UpdateOrdenById(TblOrdene orden);
        public void DeleteOrdenById(TblOrdene orden);

    }
}
