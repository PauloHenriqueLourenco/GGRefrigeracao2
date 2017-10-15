using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGRefrigeracao.modelo
{
    class Ordem_Servico
    {
        public int Codigo { get; set; }
        public int CodigoTipoServico { get; set; }
        public int CodigoAr { get; set; }
        public Decimal Valor { get; set; }

    }
}
