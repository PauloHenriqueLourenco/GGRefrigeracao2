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

namespace GGRefrigeracao.modelo
{
    public partial class FServico : Form
    {
        public FServico()
        {
            InitializeComponent();
        }

        ClienteTableAdapter ct = new ClienteTableAdapter();

        Cliente c = new Cliente();
        Servico s = new Servico();
        Ar a = new Ar();

        controle.ctrlCliente ctrlC = new controle.ctrlCliente();
        controle.ctrlServico ctrlS = new controle.ctrlServico();
        controle.ctrlAr ctrlA = new controle.ctrlServico();

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

            int erro = ctrlC.InserirCliente(c);
            if (erro == 0)
            {
                MessageBox.Show("Inclusão de cliente com êxito");
            } 
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           //aaaa
        }
    }
}
