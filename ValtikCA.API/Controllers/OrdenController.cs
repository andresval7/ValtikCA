using Microsoft.AspNetCore.Mvc;
using System.Net;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        private readonly IOrdenService _service;

        public OrdenController(IOrdenService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna un listado con todas las ordenes registradas
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<OrdenResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_service.GetOrden());
        }

        /// <summary>
        /// Permite consultar la información de una orden por su id
        /// </summary>
        /// <param name="request">Identificador de la orden a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(OrdenResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] CreateOrdenRequest request)
        {
            return Ok(_service.GetOrdenById(request.IdOrden));
        }

        /// <summary>
        /// Permite insertar una orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateOrdenRequest request)
        {
            _service.InsertOrdenById(request);
            return Ok();
        }
        /// <summary>
        /// Permite actualizar una orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateOrdenRequest request)
        {
            _service.UpdateOrdenById(request);
            return Ok();
        }
        /// <summary>
        /// Permite eliminar una orden
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteOrdenRequest request)
        {
            _service.DeleteOrdenById(request.IdOrden);
            return Ok();
        }
    }
}

