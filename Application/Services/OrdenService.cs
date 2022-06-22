using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class OrdenService : IOrdenService
    {
        private readonly IOrdenRepository _repository;
        private readonly IMapper _mapper;



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

        public OrdenResponse GetOrdenById(decimal Id)
        {
            var orden = _repository.GetOrdenById(Id);
            var ordenResponse = _mapper.Map<OrdenResponse>(orden);
            return ordenResponse;
        }


        public void InsertOrdenById(CreateOrdenRequest request)
        {
            var orden = _mapper.Map<Orden>(request);
            
            _repository.InsertOrdenById(orden);
        }

        public void UpdateOrdenById(UpdateOrdenRequest request)
        {
            var orden = _mapper.Map<Orden>(request);
            _repository.UpdateOrdenById(orden);
        }
    }
}
