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
        private readonly IProductoCategoriaRepository _repository;
        private readonly IMapper _mapper;

        public ProductoCategoriumController(IProductoCategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProductoCategoria());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetProductoCategoriaById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductoCategoriaRequest request)
        {
            var prodcategoria = _mapper.Map<ProductoCategoria>(request);
            _repository.InsertProductoCategoria(prodcategoria);
            return Ok(prodcategoria);
        }

        [HttpPut]
        public IActionResult Put(UpdateProductoCategoria request)
        {
            var prodcategoria = _mapper.Map<ProductoCategoria>(request);
            _repository.UpdateProductoCategoriaById(prodcategoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteProductoCategoria request)
        {
            var prodcategoria = _mapper.Map<ProductoCategoria>(request);
            _repository.DeleteProductoCategoriaById(prodcategoria);
            return Ok();
        }
    }
}
