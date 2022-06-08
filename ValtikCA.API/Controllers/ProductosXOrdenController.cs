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
    public class ProductosXOrdenController : ControllerBase
    {
        private readonly IProductosXordenRepository _repository;
        private readonly IMapper _mapper;

        public ProductosXOrdenController(IProductosXordenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProductoXorden());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetProductoXordenById(id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductoXordenRequest request)
        {
            var prodcategoria = _mapper.Map<ProductosXorden>(request);
            _repository.InsertProductoXorden(prodcategoria);
            return Ok(prodcategoria);
        }

        [HttpPut]
        public IActionResult Put(UpdateProductoXordenRequest request)
        {
            var prodcategoria = _mapper.Map<ProductosXorden>(request);
            _repository.UpdateProductoXordenById(prodcategoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(DeleteProductoXordenRequest request)
        {
            var prodcategoria = _mapper.Map<ProductosXorden>(request);
            _repository.DeleteProductoXordenById(prodcategoria);
            return Ok();
        }
    }
}
