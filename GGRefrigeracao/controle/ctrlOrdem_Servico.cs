using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GGRefrigeracao.DBGGRefrigeracaoDataSet;

namespace GGRefrigeracao.controle
{
    class ctrlOrdem_Servico
    {
        Ordem_ServicoTableAdapter ta = new Ordem_ServicoTableAdapter();
        Ordem_ServicoDataTable tbl = new Ordem_ServicoDataTable();
        Tipo_ServicoTableAdapter tsta = new Tipo_ServicoTableAdapter();
        ArTableAdapter ata = new ArTableAdapter();

        public int Inserir(modelo.Ordem_Servico os)
        {
            int rc = 0;
            try
            {
                rc = int.Parse(ta.InsertQuery(os.CodigoTipoServico,os.CodigoAr,os.Valor).ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = -1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Alterar(modelo.Ordem_Servico os)
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

        public int Excluir(modelo.Ordem_Servico os)
        {
            int rc = 0;
            try
            {
                ta.Delete(os.Codigo,os.CodigoTipoServico,os.CodigoAr,os.Valor);
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

        public Ordem_ServicoDataTable CarregarTabela()
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

        public int GetCodigoTipoServico(string descricao)
        {
            int rc = 0;
            try
            {
                rc = int.Parse(tsta.GetCodigo(descricao).ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = -1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int GetCodigoAr(string descricao)
        {
            int rc = 0;
            try
            {
                rc = int.Parse(ata.GetCodigo(descricao).ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = -1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

    }
}
