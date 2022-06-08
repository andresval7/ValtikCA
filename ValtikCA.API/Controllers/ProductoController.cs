using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ValtikCA.Application.Requests;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoController(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_repository.GetProducto());
        }

        [HttpGet("id")]
        public IActionResult Get(string id)
        {

            return Ok(_repository.GetProductoById(id));
        }
        [HttpPost]
        public IActionResult Post(CreateProductoRequest request)
        {
            var producto = _mapper.Map<Producto>(request);
            _repository.InsertProductoById(producto);
            return Ok(producto);
        }

        [HttpPut]
        public IActionResult Put(UpdateProductoRequest request)
        {
            var producto = _mapper.Map<Producto>(request);
            _repository.UpdateProductoById(producto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteProductoRequest request)
        {
            var producto = _mapper.Map<Producto>(request);
            _repository.DeleteProductoById(producto);
            return Ok();
        }


    }
}
