using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductosXOrdenController : ControllerBase
    {
        private readonly IProductoXordenService _service;

        public ProductosXOrdenController(IProductoXordenService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna un listado con todas los productos por orden registradas
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ProductoXordenResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_service.GetProductoXorden());
        }

        /// <summary>
        /// Permite consultar la información de un producto por orden por su id
        /// </summary>
        /// <param name="request">Identificador de un producto por orden a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoXordenResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] CreateProductoXordenRequest request)
        {
            return Ok(_service.GetProductoXordenById(request.IdProdOrden));
        }

        /// <summary>
        /// Permite insertar un producto por orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateProductoXordenRequest request)
        {
            _service.InsertProductoXorden(request);
            return Ok();
        }
        /// <summary>
        /// Permite actualizar un producto por orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateProductoXordenRequest request)
        {
            _service.UpdateProductoXordenById(request);
            return Ok();
        }
        /// <summary>
        /// Permite eliminar un producto por orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteProductoXordenRequest request)
        {
            _service.DeleteProductoXordenById(request);
            return Ok();
        }
    }
}
