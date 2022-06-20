using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IOrdenService
    {
        OrdenResponse GetOrdenById(int Id);

        IEnumerable<OrdenResponse> GetOrden();

        void InsertOrdenById(CreateOrdenRequest orden);

        void UpdateOrdenById(UpdateOrdenRequest orden);

        void DeleteOrdenById(int Id);
        void DeleteOrdenById(decimal idOrden);
        object? GetOrdenById(decimal idOrden);
    }
}
