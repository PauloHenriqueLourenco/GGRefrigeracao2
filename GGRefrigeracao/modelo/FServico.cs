using GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GGRefrigeracao.DBGGRefrigeracaoDataSet;

namespace GGRefrigeracao.modelo
{
    public partial class FServico : Form
    {
        public FServico()
        {
            InitializeComponent();
        }        

        Cliente c = new Cliente();
        Servico s = new Servico();
        Ordem_Servico os = new Ordem_Servico();
        Servico_Ordem_Servico sos = new Servico_Ordem_Servico();

        controle.ctrlCliente ctrlC = new controle.ctrlCliente();
        controle.ctrlServico ctrlS = new controle.ctrlServico();
        controle.ctrlOrdem_Servico ctrlOS = new controle.ctrlOrdem_Servico();
        controle.ctrlServico_Ordem_Servico ctrlSOS = new controle.ctrlServico_Ordem_Servico();

        private void Limpar()
        {
            nomeTextBox.Clear();
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            cmbBtu.SelectedIndex = -1;
            pickerData.Value = DateTime.Now;
            valorTextBox.Clear();            
        }
        
        private void GetCampos()
        {
            c.Nome = nomeTextBox.Text;
            c.Telefone = telefoneTextBox.Text;
            c.Endereco = enderecoTextBox.Text;
            s.Data = pickerData.Value;
            os.Valor = Decimal.Parse(valorTextBox.Text);
        }

        private void FServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBGGRefrigeracaoDataSet.Ar'. Você pode movê-la ou removê-la conforme necessário.
            this.arTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Ar);
            // TODO: esta linha de código carrega dados na tabela 'dBGGRefrigeracaoDataSet.Tipo_Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_ServicoTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Tipo_Servico);
            // TODO: esta linha de código carrega dados na tabela 'dBGGRefrigeracaoDataSet.Btu'. Você pode movê-la ou removê-la conforme necessário.            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listaServicos.Rows)
            {
                c.Nome = row.Cells[0].Value.ToString();
                c.Telefone = row.Cells[1].Value.ToString();   // Carregando Cliente
                c.Endereco = row.Cells[2].Value.ToString();

                int codigo_cliente = ctrlC.Inserir(c);
                if (codigo_cliente > 0)
                {
                    s.CodigoCliente = codigo_cliente;
                    s.Data = DateTime.Parse(row.Cells[5].Value.ToString()).Date;  // Carregando Serviço
                    
                    os.CodigoTipoServico = ctrlOS.GetCodigoTipoServico(row.Cells[3].Value.ToString());  
                    os.CodigoAr = ctrlOS.GetCodigoAr(row.Cells[4].Value.ToString());                         // Carregando Ordem_Servico
                    os.Valor = Decimal.Parse(row.Cells[6].Value.ToString());

                    sos.CodigoServico = ctrlS.Inserir(s);
                    sos.CodigoOrdemServico = ctrlOS.Inserir(os);

                    ctrlSOS.Inserir(sos);
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                        
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            GetCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCampos();
            listaServicos.Rows.Add(c.Nome, c.Telefone, c.Endereco, cmbServico.Text, cmbBtu.Text, s.Data, os.Valor);            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRelatorio fr = new FRelatorio();
            fr.Show();
        }
    }
}
