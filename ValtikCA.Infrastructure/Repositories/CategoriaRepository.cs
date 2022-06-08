using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private DBTiendaValtikContext _context;
        public CategoriaRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.TblCategoria;
        }

        public Categoria GetCategoriaById(int Id)
        {
            var categoriaExistente = _context.TblCategoria.
                FirstOrDefault(x => x.IdCategoria == (Id));

            return categoriaExistente;

        }

        public void InsertCategoriaById(Categoria categoria)
        {
            _context.TblCategoria.Add(categoria);
            _context.SaveChanges();
        }

        public void UpdateCategoriaById(Categoria categoria)
        {
            var categoriaExistente = _context.TblCategoria
                .FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            if (categoriaExistente != null)
            {
                categoriaExistente.Nombre = categoria.Nombre;
                categoriaExistente.Descripcion = categoria.Descripcion;
                categoriaExistente.Miniatura = categoria.Miniatura;
                _context.SaveChanges();
            }

        }

        public void DeleteCategoriaById(Categoria categoria)
        {
            var categoriaExistente = _context.TblCategoria
                .FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            if (categoriaExistente != null)
            {
                _context.Remove(categoriaExistente);
                _context.SaveChanges();
            }

        }
    }
}
