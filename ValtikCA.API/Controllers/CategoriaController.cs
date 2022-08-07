using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna un listado con todas las categorías registradas
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<CategoriaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]
        public IActionResult Get()
        {
            return Ok(_service.GetAllCategorias());
        }

        /// <summary>
        /// Permite consultar la información de una categoría por su id
        /// </summary>
        /// <param name="request">Identificador de la categoría a buscar</param>
        /// <returns></returns>
        [HttpGet("{IdCategoria}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(CategoriaResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] ReadCategoriaRequest request)
        {
            return Ok(_service.GetCategoriaById(request.IdCategoria));
        }

        /// <summary>
        /// Permite insertar una categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            _service.InsertCategoriaById(request);
            return Ok();
        }
        /// <summary>
        /// Permite actualizar una categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Put(UpdateCategoriaRequest request)
        {
            _service.UpdateCategoriaById(request);
            return Ok();
        }
        /// <summary>
        /// Permite eliminar una categoría
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("{IdCategoria}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteCategoriaRequest request)
        {
            _service.DeleteCategoria(request.IdCategoria);
            return Ok();
        }
    }   

}
