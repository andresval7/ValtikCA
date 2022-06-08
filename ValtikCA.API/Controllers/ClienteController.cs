using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValtikCA.Application.Requests;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCliente());
        }
        [HttpGet ("id")]
        public IActionResult Get(decimal id)
        {
            return Ok(_repository.GetClienteById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.InsertClienteById(cliente);
            return Ok(cliente);
        }

        [HttpPut]
        public IActionResult Put(UpdateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.UpdateClienteById(cliente);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.DeleteClienteById(cliente);
            return Ok();
        }
    }
}
