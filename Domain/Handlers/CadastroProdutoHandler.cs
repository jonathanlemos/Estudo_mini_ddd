using Domain.Comandos.Request;
using Domain.Comandos.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class CadastroProdutoHandler : IRequestHandler<RequestProduto, ResponseProduto>
    {
        public Task<ResponseProduto> Handle(RequestProduto request, CancellationToken cancellationToken)
        {
            var resultado = new ResponseProduto
            {
                Id = Guid.NewGuid(),
                Nome = "S9",
                Valor = 4000,
                Data = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
