using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System.Data.Sql;
using static GGRefrigeracao.DBGGRefrigeracaoDataSet;

namespace GGRefrigeracao.controle
{
    class ctrlCliente
    {
        ClienteTableAdapter ct = new ClienteTableAdapter();
        ClienteDataTable ctbl = new ClienteDataTable();

        public int InserirCliente(modelo.Cliente c)
        {
            int rc = 0;
            try
            {
                ct.Insert(c.Nome, c.Telefone, c.Endereco);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int AlterarCliente(modelo.Cliente c)
        {
            int rc = 0;
            try
            {
                ct.Update(c.Nome, c.Telefone, c.Endereco, c.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }

        public int ExcluirCliente(modelo.Cliente c)
        {
            int rc = 0;
            try
            {
                ct.Delete(c.Codigo, c.Telefone);
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
                ct.GetData();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public ClienteTableAdapter ConsultarCliente(string nome)
        {
            try
            {
                ct.GetCliente("%"+nome+"%");
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ct;
        }

        public ClienteTableAdapter GetCodigo(modelo.Cliente c, out int codigoCliente)
        {
            codigoCliente = 0;
            try
            {
                ct.FillConsulta(ctbl, c.Telefone, c.Nome);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (ctbl.Rows.Count == 0)
            {
                codigoCliente = int.Parse(ct.GetUltimoCodigo().ToString());
            }                
            return ct;
        }
    }
}
