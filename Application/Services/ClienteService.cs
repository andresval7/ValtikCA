using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteClienteById(decimal Id)
        {
            _repository.DeleteClienteById(Id);
        }

        public IEnumerable<ClienteResponse> GetCliente()
        {
            var clientes = _repository.GetCliente();
            var clienteResponse = _mapper.Map<IEnumerable<ClienteResponse>>(clientes);
            return clienteResponse;
        }

        public ClienteResponse GetClienteById(decimal Id)
        {
            var cliente = _repository.GetClienteById(Id);
            var clienteResponse = _mapper.Map<ClienteResponse>(cliente);
            return clienteResponse;
        }

        public void InsertClienteById(CreateClienteRequest request)
        {
            var categoria = _mapper.Map<Cliente>(request);
            _repository.InsertClienteById(categoria);

        }


        public void UpdateClienteById(UpdateClienteRequest request)
        {
            var categoria = _mapper.Map<Cliente>(request);
            _repository.UpdateClienteById(categoria);
        }
    }
}
