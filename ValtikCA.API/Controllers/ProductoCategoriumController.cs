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
    public class ProductoCategoriumController : ControllerBase
    {
        private readonly IProductoCategoriumRepository _repository;
        private readonly IMapper _mapper;

        public ProductoCategoriumController(IProductoCategoriumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProductoCategorium());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetProductoCategoriumById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductoCategoriumRequest request)
        {
            var prodcategoria = _mapper.Map<ProductoCategorium>(request);
            _repository.InsertProductoCategorium(prodcategoria);
            return Ok(prodcategoria);
        }

        [HttpPut]
        public IActionResult Put(UpdateProductoCategorium request)
        {
            var prodcategoria = _mapper.Map<ProductoCategorium>(request);
            _repository.UpdateProductoCategoriumById(prodcategoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteProductoCategorium request)
        {
            var prodcategoria = _mapper.Map<ProductoCategorium>(request);
            _repository.DeleteProductoCategoriumById(prodcategoria);
            return Ok();
        }
    }
}
