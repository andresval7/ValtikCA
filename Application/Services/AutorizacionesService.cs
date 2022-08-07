using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class AutorizacionesService : IAutorizacionesService
    {
        private readonly IAutorizacionesRepository _repository;
        private readonly IMapper _mapper;

        public AutorizacionesService(IAutorizacionesRepository repository, IMapper mapper)
        {
            _repository = (IAutorizacionesRepository)repository;
            _mapper = mapper;
        }

        public void DeleteAutorizacionByUser(string autorizacion)
        {
            _repository.DeleteAutorizacionByUser(autorizacion);
        }

        public IEnumerable<AutorizacionResponse> GetAutorizacion()
        {
            var autorizacion = _repository.GetAutorizacion();
            var autorizacionResponse = _mapper.Map<IEnumerable<AutorizacionResponse>>(autorizacion);
            return autorizacionResponse;
        }

        public AutorizacionResponse GetAutorizacionByUser(string user)
        {
            var autorizacion = _repository.GetAutorizacionByUser(user);
            var autorizacionResponse = _mapper.Map<AutorizacionResponse>(autorizacion);
            return autorizacionResponse;
        }

        public void InsertAutorizacionById(CreateAutorizacionRequest request)
        {
            var categoria = _mapper.Map<Autorizaciones>(request);
            _repository.InsertAutorizacionById(categoria);
        }

        public void UpdateAutorizacionById(UpdateAutorizacionRequest request)
        {
            var categoria = _mapper.Map<Autorizaciones>(request);
            _repository.UpdateAutorizacionById(categoria);
        }
    }
}
