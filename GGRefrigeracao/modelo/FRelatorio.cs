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
    public partial class FRelatorio : Form
    {
        public FRelatorio()
        {
            InitializeComponent();
        }

        RelatorioTableAdapter ta = new RelatorioTableAdapter();

        private void FRelatorio_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaDataGridView.DataSource = ta.GetServicos();
        }
    }
}
