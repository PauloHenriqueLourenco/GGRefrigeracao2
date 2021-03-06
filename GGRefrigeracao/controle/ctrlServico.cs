﻿using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GGRefrigeracao.DBGGRefrigeracaoDataSet;

namespace GGRefrigeracao.controle
{
    class ctrlServico
    {

        ServicoTableAdapter ta = new ServicoTableAdapter();
        ServicoDataTable tbl = new ServicoDataTable();

        public int Inserir(modelo.Servico s)
        {
            if (ta.GetCodigo(s.CodigoCliente,s.Data.Date) != null)
            {
                return int.Parse(ta.GetCodigo(s.CodigoCliente,s.Data.Date).ToString());
            }
            else
            {
                int rc = 0;
                try
                {
                    ta.Insert(s.CodigoCliente, s.Data.Date);
                    rc = int.Parse(ta.GetCodigo(s.CodigoCliente, s.Data.Date).ToString());
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    rc = -1;
                    Console.WriteLine(ex.Message);                    
                }
                return rc;
            }
        }

        public int Alterar(modelo.Servico s)
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

        public int Excluir(modelo.Servico s)
        {
            int rc = 0;
            try
            {
                ta.Delete(s.Codigo,s.CodigoCliente);
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

        public ServicoDataTable CarregarTabela()
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

        public ServicoDataTable GetServicos()
        {
            tbl.Clear();
            try
            {
                ta.FillByServicos(tbl);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tbl;
        }
    }
}
