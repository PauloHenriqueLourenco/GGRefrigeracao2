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

        public int Inserir(modelo.Cliente c)
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

        public int Alterar(modelo.Cliente c)
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

        public int Excluir(modelo.Cliente c)
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

        public ClienteDataTable CarregarTabela()
        {
            ctbl.Clear();
            try
            {
                ct.Fill(ctbl);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ctbl;
        }

        public ClienteDataTable GetCodigo(modelo.Cliente c)
        {
            try
            {
                ct.FillConsulta(ctbl,c.Telefone,c.Nome,c.Endereco);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ctbl;
        }

        public int GetCodigo()
        {
            int codigoCliente = 0;
            try
            {
                codigoCliente = int.Parse(ct.GetUltimoCodigo().ToString());
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }           
            return codigoCliente;
        }
    }
}
