using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Domain.Comandos.Request;
using Domain.Comandos.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public async Task<ResponseProduto> Cadastro([FromServices] IMediator mediator, [Microsoft.AspNetCore.Mvc.FromBody] RequestProduto request)
        {
            return await mediator.Send(request);
        }

    }
}