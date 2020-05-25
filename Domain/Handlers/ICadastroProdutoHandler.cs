using Domain.Comandos.Request;
using Domain.Comandos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers
{
    public interface ICadastroProdutoHandler
    {
        ResponseProduto Handle(RequestProduto request);
    }
}
