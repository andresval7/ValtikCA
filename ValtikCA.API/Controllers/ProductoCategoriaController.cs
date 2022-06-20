using Microsoft.AspNetCore.Mvc;
using System.Net;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoCategoriaController : ControllerBase
    {
      private readonly IProductoCategoriaService _service;

        public ProductoCategoriaController(IProductoCategoriaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna un listado con todas los productos por categorías registrados
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ProductoCategoriaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_service.GetProductoCategoria());
        }

        /// <summary>
        /// Permite consultar la información de un producto por categoría por su id
        /// </summary>
        /// <param name="request">Identificador del producto categoría a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoCategoriaResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] CreateProductoCategoriaRequest request)
        {
            return Ok(_service.GetProductoCategoriaById(request.IdProdCategoria));
        }

        /// <summary>
        /// Permite insertar un producto por categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateProductoCategoriaRequest request)
        {
            _service.InsertProductoCategoria(request);
            return Ok();
        }
        /// <summary>
        /// Permite actualizar un producto por categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateProductoCategoria request)
        {
            _service.UpdateProductoCategoria(request);
            return Ok();
        }
        /// <summary>
        /// Permite eliminar un producto por categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteProductoCategoria request)
        {
            _service.DeleteProductoCategoria(request.IdProducto);
            return Ok();
        }
    }
}
