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

        ServicoTableAdapter st = new ServicoTableAdapter();
        ClienteTableAdapter ct = new ClienteTableAdapter();
        ArTableAdapter at = new ArTableAdapter();

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
            this.clienteTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Cliente);
            this.btuTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Btu);
            this.fabricanteTableAdapter.Fill(this.dBGGRefrigeracaoDataSet.Fabricante);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int codigoCliente = 0;
            ct.Insert(cmbNome.Text, telefoneTextBox.Text, enderecoTextBox.Text);     
            try
            {
                codigoCliente = int.Parse(cmbNome.SelectedValue.ToString());
            }
            catch (NullReferenceException)
            {
                codigoCliente = int.Parse(ct.GetUltimoCodigo().ToString());
            }
            st.Insert(pickerData.Value, Decimal.Parse(valorTextBox.Text), codigoCliente, int.Parse(at.GetCodigoAr(int.Parse(cmbFabricante.SelectedValue.ToString()),int.Parse(cmbBtu.SelectedValue.ToString())).ToString()));
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
