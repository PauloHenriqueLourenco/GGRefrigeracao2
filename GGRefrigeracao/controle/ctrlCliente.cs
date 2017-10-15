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
        ClienteTableAdapter ta = new ClienteTableAdapter();
        ClienteDataTable tbl = new ClienteDataTable();

        public int Inserir(modelo.Cliente c)
        {
            if (ta.GetCodigo(c.Telefone) != null)
            {
                return int.Parse(ta.GetCodigo(c.Telefone).ToString());
            }
            else
            {
                int rc = 0;
                try
                {
                    ta.Insert(c.Nome, c.Telefone, c.Endereco);   
                    rc = int.Parse(ta.GetCodigo(c.Telefone).ToString());
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    rc = -1;
                    Console.WriteLine(ex.Message);                    
                }
                return rc;
            }
        }

       /* public int Alterar(modelo.Cliente c)
        {
            int rc = 0;
            try
            {
                ta.Update(c.Nome, c.Telefone, c.Endereco, c.Codigo);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                rc = 1;
                Console.WriteLine(ex.Message);
            }
            return rc;
        }*/

        public int Excluir(modelo.Cliente c)
        {
            int rc = 0;
            try
            {
                ta.Delete(c.Codigo, c.Telefone);
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
