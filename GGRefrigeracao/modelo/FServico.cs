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
        Ar a = new Ar();

        controle.ctrlCliente ctrlC = new controle.ctrlCliente();
        controle.ctrlServico ctrlS = new controle.ctrlServico();
        controle.ctrlAr ctrlA = new controle.ctrlAr();

        private void Limpar()
        {            
            cmbNome.SelectedIndex = -1;
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            cmbFabricante.SelectedIndex = -1;
            cmbBtu.SelectedIndex = -1;
            pickerData.Value = DateTime.Now;
            valorTextBox.Clear();            
        }
        
        private void GetCampos()
        {
            DataGridView dt = new DataGridView();
            dt.DataSource = ctrlC.GetCodigo(c);
            c.Nome = cmbNome.Text;
            c.Telefone = telefoneTextBox.Text;
            c.Endereco = enderecoTextBox.Text;
            ClienteDataTable cTable = ctrlC.GetCodigo(c);
            if (cTable.Rows.Count == 0)
                c.Codigo = ctrlC.GetCodigo();
            else
            {
                FCliente fc = new FCliente(cTable);
                fc.Show();                
            }        

            a.CodigoFabricante = int.Parse(cmbFabricante.SelectedValue.ToString());
            a.CodigoBtu = int.Parse(cmbBtu.SelectedValue.ToString());
            a.Codigo = ctrlA.GetCodigo(a);
        }

        private void FServico_Load(object sender, EventArgs e)
        {
            this.btuTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Btu);
            this.fabricanteTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Fabricante);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            c.Nome = cmbNome.Text;
            c.Telefone = telefoneTextBox.Text;
            c.Endereco = enderecoTextBox.Text;
            s.Endereco = c.Endereco;
            s.CodigoAr = int.Parse(arTableAdapter.GetCodigoAr(int.Parse(cmbFabricante.SelectedValue.ToString()),int.Parse(cmbBtu.SelectedValue.ToString())).ToString());
            s.CodigoCliente = ctrlC.GetCodigo();
            s.Data = pickerData.Value;
            s.Valor = int.Parse(valorTextBox.Text);
            ctrlC.Inserir(c);
            int erro = ctrlS.Inserir(s);
            if (erro == 0)
            {
                MessageBox.Show("Serviço registrado com êxito");
                Limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctrlS.CarregarTabela();      
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir o serviço "+codigo+" ?","Confirma",MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                s.Codigo = codigo; 
                int erro = ctrlS.Excluir(s);
                if (erro == 0)
                {
                    MessageBox.Show("Exclusão de serviço realizada com êxito");
                    dataGridView1.DataSource = ctrlS.CarregarTabela();
                    Limpar();
                }
            }            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            GetCampos();
        }
    }
}
