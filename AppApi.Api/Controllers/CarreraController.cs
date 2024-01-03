using ApiPrayaga.Application.Handlers.Carrera.Commands.Create;
using ApiPrayaga.Application.Handlers.Carrera.Commands.Delete;
using ApiPrayaga.Application.Handlers.Carrera.Commands.Update;
using ApiPrayaga.Application.Handlers.Carrera.Queries.GetAll;
using ApiPrayaga.Application.Handlers.Carrera.Queries.GetId;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiPrayaga.Application.CustonPagination;
using ApiPrayaga.Application.Wrappers;
using Newtonsoft.Json;

namespace ApiPrayaga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarreraController(IMediator mediator) => _mediator = mediator;

        [HttpGet("GetCarreraController")]
        [ProducesResponseType(typeof(IEnumerable<CarreraModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCarreraController(string? NombreCarrera,string? CodigoCarrera, int PageNumber, int PageSize)
        {
            var query = new GetAllCarreraQuery(NombreCarrera, CodigoCarrera, PageNumber, PageSize);
            var contacto = await _mediator.Send(query);
            var metaData = new MetaData
            {
                TotalCount =contacto.TotalCount,
                PageSize = contacto.PageSize,
                CurrentPage = contacto.CurrentPage,
                TotalPages = contacto.TotalPages,
                HasNextPage = contacto.HasNextPage,
                HasPreviousPage = contacto.HasPreviousPage
            };
            var response = new ApiResponse<IEnumerable<CarreraModel>>(contacto) { Meta = metaData };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metaData));
            return Ok(response);
        } 
        [HttpGet("GetIdCarrera")]
        [ProducesResponseType(typeof(IEnumerable<CarreraIdModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetIdCarrera(int FaculdadId)
        {
            var query = new GetIdCarreraQuery(FaculdadId);
            var contacto = await _mediator.Send(query);     
            return Ok(contacto);
        }

        [HttpPost(Name = "CrearCarrera")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [DisableRequestSizeLimit, RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue, ValueLengthLimit = int.MaxValue)]

        public async Task<ActionResult<int>> CrearCarrera(CreateCarreraCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut(Name = "UpdateCarrera")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateCarrera(UpdateCarreraCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete(Name = "DeleteCarrera")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteCarrera(int CarreraId, int UserDeleteId)
        {
            DeleteCarreraCommand ticket = new DeleteCarreraCommand
            {
                CarreraId = CarreraId,
                UserDeleteId = UserDeleteId
            };
            return Ok(await _mediator.Send(ticket));
        }
    }
}
