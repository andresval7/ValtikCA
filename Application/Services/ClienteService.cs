using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteService _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteService repository, IMapper mapper)
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

        public void InsertClienteById(CreateClienteRequest cliente)
        {
            _repository.InsertClienteById(cliente);
        }

        public void InsertClienteById(Cliente cliente)
        {
            _repository.InsertClienteById(cliente);
        }

        public void UpdateClienteById(UpdateClienteRequest cliente)
        {
            _repository.UpdateClienteById(cliente);
        }
    }
}
