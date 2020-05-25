using System;
using System.Collections.Generic;
using System.Text;
using Domain.Comandos.Responses;
using MediatR;

namespace Domain.Comandos.Request
{
    public class RequestProduto : IRequest<ResponseProduto>
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
