using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGRefrigeracao.modelo
{
    class Servico
    {
        public int Codigo { get; set; }
        public string Endereco { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoAr { get; set; }

    }
}
