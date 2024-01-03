using ApiPrayaga.Application.Handlers.Facultad.Commands.Create;
using ApiPrayaga.Application.Handlers.Facultad.Commands.Delete;
using ApiPrayaga.Application.Handlers.Facultad.Commands.Update;
using ApiPrayaga.Application.Handlers.Facultad.Queries.GetAll;
using ApiPrayaga.Application.Handlers.Facultad.Queries.GetId;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiPrayaga.Application.CustonPagination;
using ApiPrayaga.Application.Wrappers;
using Newtonsoft.Json;
using ApiPrayaga.Application.Handlers.Facultad.Queries.GetDelete;

namespace ApiPrayaga.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultadController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FacultadController(IMediator mediator) => _mediator = mediator;

        [HttpGet("GetFacultad")]
        [ProducesResponseType(typeof(IEnumerable<FacultadModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFacultad(string? NombreFacultad,string? CodigoFacultad, int PageNumber, int PageSize)
        {
            var query = new GetAllFacultadQuery(NombreFacultad, CodigoFacultad, PageNumber, PageSize);
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
            var response = new ApiResponse<IEnumerable<FacultadModel>>(contacto) { Meta = metaData };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metaData));
            return Ok(response);
            //return Ok(tickets);
        } 
        [HttpGet("GetIdFacultad")]
        [ProducesResponseType(typeof(IEnumerable<FacultadIdModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetIdFacultad(int FaculdadId)
        {
            var query = new GetIdFacultadQuery(FaculdadId);
            var contacto = await _mediator.Send(query);     
            return Ok(contacto);
        }

        [HttpGet("GetFacultadDelete")]
        [ProducesResponseType(typeof(IEnumerable<FacultadModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetFacultadDelete(string? NombreFacultad, string? CodigoFacultad)
        {
            var query = new GetAllFacultadDeleteQuery(NombreFacultad, CodigoFacultad);
            var facultad = await _mediator.Send(query);            
            return Ok(facultad);
        }

        [HttpPost(Name = "CrearFacultad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [DisableRequestSizeLimit, RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue, ValueLengthLimit = int.MaxValue)]

        public async Task<ActionResult<int>> CrearFacultad(CreateFacultadCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut(Name = "UpdateFacultad")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateFacultad(UpdateFacultadCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete(Name = "DeleteFacultad")]

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteFacultad(int FacultadId, int UserDeleteId)
        {
            DeleteFacultadCommand ticket = new DeleteFacultadCommand
            {
                FacultadId = FacultadId,
                UserDeleteId = UserDeleteId
            };
            return Ok(await _mediator.Send(ticket));
        }
    }
}
