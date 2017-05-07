using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGRefrigeracao.controle
{
    class ctrlAr
    {

        ArTableAdapter at = new ArTableAdapter();

        public int Inserir(modelo.Ar a)
        {
            int rc = 0;
            try
            {
                at.Insert()
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Alterar(modelo.Servico s)
        {
            int rc = 0;
            try
            {
                st.Update(s.Data, s.Valor, s.CodigoCliente, s.CodigoAr, s.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Excluir(modelo.Servico s)
        {
            int rc = 0;
            try
            {
                st.Delete(s.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public void CarregarTabela()
        {
            try
            {
                st.GetData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
