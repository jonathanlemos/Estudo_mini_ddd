using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Comandos.Responses
{
    public class ResponseProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
