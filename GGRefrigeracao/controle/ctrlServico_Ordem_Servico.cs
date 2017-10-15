using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GGRefrigeracao.DBGGRefrigeracaoDataSet;

namespace GGRefrigeracao.controle
{
    class ctrlServico_Ordem_Servico
    {
        Servico_Ordem_ServicoTableAdapter ta = new Servico_Ordem_ServicoTableAdapter();
        Servico_Ordem_ServicoDataTable tbl = new Servico_Ordem_ServicoDataTable();

        public int Inserir(modelo.Servico_Ordem_Servico sos)
        {
            int rc = 0;
            try
            {
                ta.Insert(sos.CodigoServico,sos.CodigoOrdemServico);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Alterar(modelo.Servico_Ordem_Servico os)
        {
            int rc = 0;
            try
            {
                ta.Update(tbl);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Excluir(modelo.Servico_Ordem_Servico sos)
        {
            int rc = 0;
            try
            {
                ta.Delete(sos.CodigoServico,sos.CodigoOrdemServico);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        /*public void CarregarTabela()
        {
            try
            {
                st.GetData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        } */

        public Servico_Ordem_ServicoDataTable CarregarTabela()
        {
            tbl.Clear();
            try
            {
                ta.Fill(tbl);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tbl;
        }
    }
}
