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
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaController(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCategoria());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetCategoriaById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategorium>(request);
            _repository.InsertCategoriaById(categoria);
            return Ok(categoria);
        }

        [HttpPut]
        public IActionResult Put(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategorium>(request);
            _repository.UpdateCategoriaById(categoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategorium>(request);
            _repository.DeleteCategoriaById(categoria);
            return Ok();
        }
    }
}
