using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> GetCategoria();
        public Categoria GetCategoriaById(int Id);
        public void InsertCategoriaById(Categoria categoria);
        public void UpdateCategoriaById(Categoria categoria);
        public void DeleteCategoriaById(Categoria categoria);
    }
}
