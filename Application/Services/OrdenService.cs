using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Services
{
    public class OrdenService : IOrdenService
    {
        private readonly IOrdenService _repository;
        private readonly IMapper _mapper;

        public void DeleteOrdenById(int Id)
        {
            _repository.DeleteOrdenById(Id);
        }

        public void DeleteOrdenById(decimal idOrden)
        {
            _repository.DeleteOrdenById(idOrden);
        }

        public IEnumerable<OrdenResponse> GetOrden()
        {
            var ordenes = _repository.GetOrden();
            var ordenesResponse = _mapper.Map<IEnumerable<OrdenResponse>>(ordenes);
            return ordenesResponse;
        }

        public OrdenResponse GetOrdenById(int Id)
        {
            var orden = _repository.GetOrdenById(Id);
            var ordenResponse = _mapper.Map<OrdenResponse>(orden);
            return _repository.GetOrdenById(Id);
        }

        public object? GetOrdenById(decimal idOrden)
        {
            return _repository.GetOrdenById(idOrden);
        }

        public void InsertOrdenById(CreateOrdenRequest orden)
        {
            _repository.InsertOrdenById(orden);
        }

        public void UpdateOrdenById(UpdateOrdenRequest orden)
        {
            _repository.UpdateOrdenById(orden);
        }
    }
}
