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
                at.Insert(a.CodigoFabricante, a.CodigoBtu);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Alterar(modelo.Ar a)
        {
            int rc = 0;
            try
            {
                at.Update(a.CodigoFabricante, a.CodigoBtu, a.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int Excluir(modelo.Ar a)
        {
            int rc = 0;
            try
            {
                at.Delete(a.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int GetCodigo(modelo.Ar a)
        {
            int codigo = 0;
            try
            {
                codigo = int.Parse(at.GetCodigoAr(a.CodigoFabricante, a.CodigoBtu).ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return codigo;
        }

        public void CarregarTabela()
        {
            try
            {
                at.GetData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
