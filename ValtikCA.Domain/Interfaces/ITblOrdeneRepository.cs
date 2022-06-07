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
        public IEnumerable<TblOrdene> GetTblOrdenes();
        public TblOrdene GetTblOrdenesById(string Id);
        public void InsertTblOrdenes(TblOrdene tblOrdene);
        public void UpdateTblOrdenes(TblOrdene tblOrdene);
        public void DeleteTblOrdenes(TblOrdene tblOrdene);

    }
}
