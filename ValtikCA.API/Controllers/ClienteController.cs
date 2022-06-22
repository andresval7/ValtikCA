using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna un listado con todas los clientes registrados
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ClienteResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_service.GetCliente());
        }

        /// <summary>
        /// Permite consultar la información de un cliente por su id
        /// </summary>
        /// <param name="request">Identificador del cliente a buscar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClienteResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] CreateClienteRequest request)
        {
            return Ok(_service.GetClienteById(request.IdCliente));
        }

        /// <summary>
        /// Permite insertar un cliente
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateClienteRequest request)
        {
            _service.InsertClienteById(request);
            return Ok();
        }
        /// <summary>
        /// Permite actualizar un cliente
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateClienteRequest request)
        {
            _service.UpdateClienteById(request);
            return Ok();
        }
        /// <summary>
        /// Permite eliminar un cliente
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {
            _service.DeleteClienteById(request.IdCliente);
            return Ok();
        }
    }
}

