namespace GGRefrigeracao.modelo
{
    partial class FServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label codigoFabricanteLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label valorLabel;
            this.dBGGRefrigeracaoDataSet = new GGRefrigeracao.DBGGRefrigeracaoDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBtu = new System.Windows.Forms.ComboBox();
            this.btuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.fabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arTableAdapter = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.ArTableAdapter();
            this.fabricanteTableAdapter = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.FabricanteTableAdapter();
            this.btuTableAdapter = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.BtuTableAdapter();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.ServicoTableAdapter();
            this.pickerData = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            codigoFabricanteLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBGGRefrigeracaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 25);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(6, 58);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 2;
            telefoneLabel.Text = "Telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(6, 91);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 4;
            enderecoLabel.Text = "Endereco:";
            // 
            // codigoFabricanteLabel
            // 
            codigoFabricanteLabel.AutoSize = true;
            codigoFabricanteLabel.Location = new System.Drawing.Point(6, 36);
            codigoFabricanteLabel.Name = "codigoFabricanteLabel";
            codigoFabricanteLabel.Size = new System.Drawing.Size(57, 13);
            codigoFabricanteLabel.TabIndex = 0;
            codigoFabricanteLabel.Text = "Fabricante";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(256, 174);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 4;
            dataLabel.Text = "Data:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(256, 225);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(74, 13);
            valorLabel.TabIndex = 5;
            valorLabel.Text = "Valor Cobrado";
            // 
            // dBGGRefrigeracaoDataSet
            // 
            this.dBGGRefrigeracaoDataSet.DataSetName = "DBGGRefrigeracaoDataSet";
            this.dBGGRefrigeracaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dBGGRefrigeracaoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BtuTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FabricanteTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GGRefrigeracao.DBGGRefrigeracaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNome);
            this.groupBox1.Controls.Add(enderecoLabel);
            this.groupBox1.Controls.Add(this.enderecoTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cmbNome
            // 
            this.cmbNome.DataSource = this.clienteBindingSource;
            this.cmbNome.DisplayMember = "Nome";
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(64, 22);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(422, 21);
            this.cmbNome.TabIndex = 6;
            this.cmbNome.ValueMember = "Codigo";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(64, 88);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(294, 20);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(64, 55);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBtu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbFabricante);
            this.groupBox2.Controls.Add(codigoFabricanteLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ar Condicionado";
            // 
            // cmbBtu
            // 
            this.cmbBtu.DataSource = this.btuBindingSource;
            this.cmbBtu.DisplayMember = "Capacidade";
            this.cmbBtu.FormattingEnabled = true;
            this.cmbBtu.Location = new System.Drawing.Point(95, 66);
            this.cmbBtu.Name = "cmbBtu";
            this.cmbBtu.Size = new System.Drawing.Size(121, 21);
            this.cmbBtu.TabIndex = 6;
            this.cmbBtu.ValueMember = "Codigo";
            // 
            // btuBindingSource
            // 
            this.btuBindingSource.DataMember = "Btu";
            this.btuBindingSource.DataSource = this.dBGGRefrigeracaoDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Capacidade Btu";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DataSource = this.fabricanteBindingSource;
            this.cmbFabricante.DisplayMember = "Descricao";
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(69, 33);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricante.TabIndex = 1;
            this.cmbFabricante.ValueMember = "Codigo";
            // 
            // fabricanteBindingSource
            // 
            this.fabricanteBindingSource.DataMember = "Fabricante";
            this.fabricanteBindingSource.DataSource = this.dBGGRefrigeracaoDataSet;
            // 
            // arBindingSource
            // 
            this.arBindingSource.DataMember = "Ar";
            this.arBindingSource.DataSource = this.dBGGRefrigeracaoDataSet;
            // 
            // arTableAdapter
            // 
            this.arTableAdapter.ClearBeforeFill = true;
            // 
            // fabricanteTableAdapter
            // 
            this.fabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // btuTableAdapter
            // 
            this.btuTableAdapter.ClearBeforeFill = true;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.dBGGRefrigeracaoDataSet;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // pickerData
            // 
            this.pickerData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicoBindingSource, "Data", true));
            this.pickerData.Location = new System.Drawing.Point(295, 170);
            this.pickerData.Name = "pickerData";
            this.pickerData.Size = new System.Drawing.Size(229, 20);
            this.pickerData.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(valorLabel);
            this.groupBox3.Controls.Add(this.valorTextBox);
            this.groupBox3.Controls.Add(dataLabel);
            this.groupBox3.Controls.Add(this.pickerData);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(11, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 280);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(336, 221);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 6;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(7, 19);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(7, 48);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(7, 77);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(7, 110);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExcluir);
            this.groupBox4.Controls.Add(this.btnAlterar);
            this.groupBox4.Controls.Add(this.btnConsultar);
            this.groupBox4.Controls.Add(this.btnInserir);
            this.groupBox4.Location = new System.Drawing.Point(561, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(88, 146);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(568, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 292);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FServico";
            this.Text = "FServico";
            this.Load += new System.EventHandler(this.FServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBGGRefrigeracaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DBGGRefrigeracaoDataSet dBGGRefrigeracaoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DBGGRefrigeracaoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DBGGRefrigeracaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource arBindingSource;
        private DBGGRefrigeracaoDataSetTableAdapters.ArTableAdapter arTableAdapter;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.BindingSource fabricanteBindingSource;
        private DBGGRefrigeracaoDataSetTableAdapters.FabricanteTableAdapter fabricanteTableAdapter;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.ComboBox cmbBtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource btuBindingSource;
        private DBGGRefrigeracaoDataSetTableAdapters.BtuTableAdapter btuTableAdapter;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private DBGGRefrigeracaoDataSetTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.DateTimePicker pickerData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLimpar;
    }
}