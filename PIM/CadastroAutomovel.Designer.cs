namespace PIM
{
    partial class CadastroAutomovel
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
            this.BtnCancelaAutomovel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFabric = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mskChassi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mskRenavam = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelaAutomovel
            // 
            this.BtnCancelaAutomovel.Location = new System.Drawing.Point(575, 365);
            this.BtnCancelaAutomovel.Name = "BtnCancelaAutomovel";
            this.BtnCancelaAutomovel.Size = new System.Drawing.Size(101, 65);
            this.BtnCancelaAutomovel.TabIndex = 52;
            this.BtnCancelaAutomovel.Text = "Cancelar";
            this.BtnCancelaAutomovel.UseVisualStyleBackColor = true;
            this.BtnCancelaAutomovel.Click += new System.EventHandler(this.BtnCancelaAutomovel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbModelo);
            this.groupBox3.Location = new System.Drawing.Point(290, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ano modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbModelo.Location = new System.Drawing.Point(6, 17);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(94, 21);
            this.cbModelo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskPlaca);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Placa";
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(6, 19);
            this.mskPlaca.Mask = "000-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(55, 20);
            this.mskPlaca.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFabric);
            this.groupBox2.Location = new System.Drawing.Point(148, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ano fabric.";
            // 
            // cbFabric
            // 
            this.cbFabric.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFabric.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFabric.FormattingEnabled = true;
            this.cbFabric.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbFabric.Location = new System.Drawing.Point(6, 17);
            this.cbFabric.Name = "cbFabric";
            this.cbFabric.Size = new System.Drawing.Size(94, 21);
            this.cbFabric.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mskChassi);
            this.groupBox6.Location = new System.Drawing.Point(428, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 46);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chassi";
            // 
            // mskChassi
            // 
            this.mskChassi.Location = new System.Drawing.Point(6, 19);
            this.mskChassi.Mask = "00000000000000000";
            this.mskChassi.Name = "mskChassi";
            this.mskChassi.Size = new System.Drawing.Size(114, 20);
            this.mskChassi.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMarca);
            this.groupBox4.Location = new System.Drawing.Point(148, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 46);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chevrolet",
            "Mercedes",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Pegeout",
            "Jeep",
            "Renaut",
            "Toyota",
            "Volkswagen",
            "Chery",
            "Jac Motors"});
            this.cbMarca.Location = new System.Drawing.Point(6, 18);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(94, 21);
            this.cbMarca.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtCidade);
            this.groupBox13.Location = new System.Drawing.Point(6, 173);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(114, 46);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 19);
            this.txtCidade.MaxLength = 25;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtKM);
            this.groupBox15.Location = new System.Drawing.Point(290, 121);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(114, 46);
            this.groupBox15.TabIndex = 11;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Quilometragem";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(6, 19);
            this.txtKM.MaxLength = 10;
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(100, 20);
            this.txtKM.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.groupBox25);
            this.groupBox19.Controls.Add(this.groupBox24);
            this.groupBox19.Controls.Add(this.groupBox23);
            this.groupBox19.Controls.Add(this.groupBox22);
            this.groupBox19.Controls.Add(this.groupBox21);
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.groupBox7);
            this.groupBox19.Controls.Add(this.groupBox1);
            this.groupBox19.Controls.Add(this.groupBox6);
            this.groupBox19.Controls.Add(this.groupBox13);
            this.groupBox19.Controls.Add(this.groupBox2);
            this.groupBox19.Controls.Add(this.groupBox3);
            this.groupBox19.Controls.Add(this.groupBox15);
            this.groupBox19.Controls.Add(this.groupBox4);
            this.groupBox19.Location = new System.Drawing.Point(12, 26);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(572, 250);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Geral";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.cbUF);
            this.groupBox25.Location = new System.Drawing.Point(148, 173);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(114, 46);
            this.groupBox25.TabIndex = 14;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "UF";
            // 
            // cbUF
            // 
            this.cbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL ",
            "AP",
            "AM ",
            "BA",
            "CE ",
            "DF",
            "ES ",
            "GO",
            "MA ",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR ",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(6, 18);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(65, 21);
            this.cbUF.TabIndex = 2;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.cbTipo);
            this.groupBox24.Location = new System.Drawing.Point(428, 121);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(114, 46);
            this.groupBox24.TabIndex = 12;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "1.0",
            "1.4",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "2.4",
            "2.5",
            "3.0",
            "3.5"});
            this.cbTipo.Location = new System.Drawing.Point(6, 18);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(65, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.cbPortas);
            this.groupBox23.Location = new System.Drawing.Point(148, 121);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(114, 46);
            this.groupBox23.TabIndex = 10;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Portas";
            // 
            // cbPortas
            // 
            this.cbPortas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPortas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5"});
            this.cbPortas.Location = new System.Drawing.Point(6, 18);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(65, 21);
            this.cbPortas.TabIndex = 2;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.groupBox26);
            this.groupBox22.Controls.Add(this.cbCombustivel);
            this.groupBox22.Location = new System.Drawing.Point(6, 121);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(114, 46);
            this.groupBox22.TabIndex = 9;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Combustivel";
            // 
            // groupBox26
            // 
            this.groupBox26.Location = new System.Drawing.Point(97, 36);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(572, 176);
            this.groupBox26.TabIndex = 39;
            this.groupBox26.TabStop = false;
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCombustivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Items.AddRange(new object[] {
            "Diesel",
            "Etanol",
            "Flex",
            "Gaz",
            "Gasolina"});
            this.cbCombustivel.Location = new System.Drawing.Point(6, 18);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(94, 21);
            this.cbCombustivel.TabIndex = 2;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.cbCor);
            this.groupBox21.Location = new System.Drawing.Point(428, 69);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(114, 46);
            this.groupBox21.TabIndex = 8;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Cor";
            // 
            // cbCor
            // 
            this.cbCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Amarelo/Dourado",
            "Azul",
            "Branco",
            "Cinza",
            "Marrom/Bege",
            "Prata",
            "Preto",
            "Verde",
            "Vermelho",
            "Laranja"});
            this.cbCor.Location = new System.Drawing.Point(6, 18);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(94, 21);
            this.cbCor.TabIndex = 2;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtModelo);
            this.groupBox20.Location = new System.Drawing.Point(290, 69);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(114, 46);
            this.groupBox20.TabIndex = 7;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 19);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mskRenavam);
            this.groupBox7.Location = new System.Drawing.Point(6, 69);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 46);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Renavam";
            // 
            // mskRenavam
            // 
            this.mskRenavam.Location = new System.Drawing.Point(6, 19);
            this.mskRenavam.Mask = "00000000000";
            this.mskRenavam.Name = "mskRenavam";
            this.mskRenavam.Size = new System.Drawing.Size(79, 20);
            this.mskRenavam.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(315, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 65);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(445, 365);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 65);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // CadastroAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 448);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.BtnCancelaAutomovel);
            this.Name = "CadastroAutomovel";
            this.Text = "Cadastro de Automovel";
            this.Load += new System.EventHandler(this.CadastroAutomovel_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaAutomovel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.ComboBox cbFabric;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.MaskedTextBox mskChassi;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.MaskedTextBox mskRenavam;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}