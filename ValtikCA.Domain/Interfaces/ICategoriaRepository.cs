using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<TblCategorium> GetCategoria();
        public TblCategorium GetCategoriaById(int Id);
        public void InsertCategoriaById(TblCategorium categoria);
        public void UpdateCategoriaById(TblCategorium categoria);
        public void DeleteCategoriaById(TblCategorium categoria);
    }
}
