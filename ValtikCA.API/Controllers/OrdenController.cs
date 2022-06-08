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
    public class OrdenController : ControllerBase
    {
        private readonly IOrdenRepository _repository;
        private readonly IMapper _mapper;

        public OrdenController(IOrdenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetOrden());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetOrdenById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateOrdenRequest request)
        {
            var categoria = _mapper.Map<Orden>(request);
            _repository.InsertOrdenById(categoria);
            return Ok(categoria);
        }

        [HttpPut]
        public IActionResult Put(UpdateOrdenRequest request)
        {
            var categoria = _mapper.Map<Orden>(request);
            _repository.UpdateOrdenById(categoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteOrdenRequest request)
        {
            var categoria = _mapper.Map<Orden>(request);
            _repository.DeleteOrdenById(categoria);
            return Ok();
        }
    }
}
