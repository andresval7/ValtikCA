using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface ICategoriaService
    {
        CategoriaResponse GetCategoriaById(int id);
        IEnumerable<CategoriaResponse> GetAllCategorias();

        void InsertCategoriaById(CreateCategoriaRequest categoria);

        void UpdateCategoriaById(UpdateCategoriaRequest categoria);

        void DeleteCategoria(int id);
    }

}
