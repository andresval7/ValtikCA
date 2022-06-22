using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IOrdenService
    {
        OrdenResponse GetOrdenById(decimal Id);

        IEnumerable<OrdenResponse> GetOrden();

        void InsertOrdenById(CreateOrdenRequest orden);

        void UpdateOrdenById(UpdateOrdenRequest orden);

        void DeleteOrdenById(decimal idOrden);

    }
}
