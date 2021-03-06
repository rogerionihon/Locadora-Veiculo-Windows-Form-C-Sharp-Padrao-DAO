﻿namespace PIM
{
    partial class AluguelAutomovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AluguelAutomovel));
            this.grbCli = new System.Windows.Forms.GroupBox();
            this.grbveiculos = new System.Windows.Forms.GroupBox();
            this.rbtVeiculo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtPessoaJ = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtPessoaF = new System.Windows.Forms.RadioButton();
            this.grbOpcaoLoc = new System.Windows.Forms.GroupBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.txtValorServ = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFormPag = new System.Windows.Forms.Label();
            this.lblFormLoc = new System.Windows.Forms.Label();
            this.cmbFormLoc = new System.Windows.Forms.ComboBox();
            this.cmbFormPag = new System.Windows.Forms.ComboBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.lblLocacao = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.txtCodFis = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCodJur = new System.Windows.Forms.TextBox();
            this.txtRazSoc = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbPessoaF = new System.Windows.Forms.GroupBox();
            this.grbPessoaJ = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCodCheckin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRealizarCheckin = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelaAluguelAutomovel = new System.Windows.Forms.Button();
            this.grbCli.SuspendLayout();
            this.grbveiculos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbOpcaoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.grbPessoaF.SuspendLayout();
            this.grbPessoaJ.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCli
            // 
            this.grbCli.BackColor = System.Drawing.Color.Transparent;
            this.grbCli.Controls.Add(this.grbveiculos);
            this.grbCli.Controls.Add(this.groupBox4);
            this.grbCli.Controls.Add(this.groupBox3);
            this.grbCli.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCli.Location = new System.Drawing.Point(16, 75);
            this.grbCli.Margin = new System.Windows.Forms.Padding(5);
            this.grbCli.Name = "grbCli";
            this.grbCli.Padding = new System.Windows.Forms.Padding(5);
            this.grbCli.Size = new System.Drawing.Size(431, 55);
            this.grbCli.TabIndex = 9;
            this.grbCli.TabStop = false;
            this.grbCli.Text = "Escolha uma opção";
            // 
            // grbveiculos
            // 
            this.grbveiculos.Controls.Add(this.rbtVeiculo);
            this.grbveiculos.Location = new System.Drawing.Point(8, 15);
            this.grbveiculos.Name = "grbveiculos";
            this.grbveiculos.Size = new System.Drawing.Size(117, 32);
            this.grbveiculos.TabIndex = 6;
            this.grbveiculos.TabStop = false;
            // 
            // rbtVeiculo
            // 
            this.rbtVeiculo.AutoSize = true;
            this.rbtVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.rbtVeiculo.Checked = true;
            this.rbtVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtVeiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVeiculo.Location = new System.Drawing.Point(16, 11);
            this.rbtVeiculo.Name = "rbtVeiculo";
            this.rbtVeiculo.Size = new System.Drawing.Size(73, 20);
            this.rbtVeiculo.TabIndex = 6;
            this.rbtVeiculo.TabStop = true;
            this.rbtVeiculo.Text = "Veículo";
            this.rbtVeiculo.UseVisualStyleBackColor = false;
            this.rbtVeiculo.CheckedChanged += new System.EventHandler(this.rbtVeiculo_CheckedChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtPessoaJ);
            this.groupBox4.Location = new System.Drawing.Point(269, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(145, 32);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // rbtPessoaJ
            // 
            this.rbtPessoaJ.AutoSize = true;
            this.rbtPessoaJ.BackColor = System.Drawing.Color.Transparent;
            this.rbtPessoaJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtPessoaJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPessoaJ.Location = new System.Drawing.Point(10, 10);
            this.rbtPessoaJ.Margin = new System.Windows.Forms.Padding(5);
            this.rbtPessoaJ.Name = "rbtPessoaJ";
            this.rbtPessoaJ.Size = new System.Drawing.Size(126, 20);
            this.rbtPessoaJ.TabIndex = 5;
            this.rbtPessoaJ.Text = "Pessoa Juridica";
            this.rbtPessoaJ.UseVisualStyleBackColor = false;
            this.rbtPessoaJ.CheckedChanged += new System.EventHandler(this.rbtPessoaJ_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbtPessoaF);
            this.groupBox3.Location = new System.Drawing.Point(142, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(117, 32);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rbtPessoaF
            // 
            this.rbtPessoaF.AutoSize = true;
            this.rbtPessoaF.BackColor = System.Drawing.Color.Transparent;
            this.rbtPessoaF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtPessoaF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPessoaF.Location = new System.Drawing.Point(8, 11);
            this.rbtPessoaF.Margin = new System.Windows.Forms.Padding(5);
            this.rbtPessoaF.Name = "rbtPessoaF";
            this.rbtPessoaF.Size = new System.Drawing.Size(112, 20);
            this.rbtPessoaF.TabIndex = 4;
            this.rbtPessoaF.Text = "Pessoa Fisica";
            this.rbtPessoaF.UseVisualStyleBackColor = false;
            this.rbtPessoaF.CheckedChanged += new System.EventHandler(this.rbtPessoaF_CheckedChanged);
            // 
            // grbOpcaoLoc
            // 
            this.grbOpcaoLoc.Controls.Add(this.Calcular);
            this.grbOpcaoLoc.Controls.Add(this.txtValorServ);
            this.grbOpcaoLoc.Controls.Add(this.lblValor);
            this.grbOpcaoLoc.Controls.Add(this.lblFormPag);
            this.grbOpcaoLoc.Controls.Add(this.lblFormLoc);
            this.grbOpcaoLoc.Controls.Add(this.cmbFormLoc);
            this.grbOpcaoLoc.Controls.Add(this.cmbFormPag);
            this.grbOpcaoLoc.Controls.Add(this.lblDevolucao);
            this.grbOpcaoLoc.Controls.Add(this.dtpDevolucao);
            this.grbOpcaoLoc.Controls.Add(this.dtpLocacao);
            this.grbOpcaoLoc.Controls.Add(this.lblLocacao);
            this.grbOpcaoLoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpcaoLoc.Location = new System.Drawing.Point(16, 490);
            this.grbOpcaoLoc.Margin = new System.Windows.Forms.Padding(5);
            this.grbOpcaoLoc.Name = "grbOpcaoLoc";
            this.grbOpcaoLoc.Padding = new System.Windows.Forms.Padding(5);
            this.grbOpcaoLoc.Size = new System.Drawing.Size(795, 185);
            this.grbOpcaoLoc.TabIndex = 10;
            this.grbOpcaoLoc.TabStop = false;
            this.grbOpcaoLoc.Text = "Opções de locação";
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.White;
            this.Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calcular.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Image = global::PIM.Properties.Resources.issoooo;
            this.Calcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Calcular.Location = new System.Drawing.Point(576, 107);
            this.Calcular.Margin = new System.Windows.Forms.Padding(5);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(81, 57);
            this.Calcular.TabIndex = 12;
            this.Calcular.Text = "Calcular";
            this.Calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txtValorServ
            // 
            this.txtValorServ.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorServ.Location = new System.Drawing.Point(576, 66);
            this.txtValorServ.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorServ.Name = "txtValorServ";
            this.txtValorServ.Size = new System.Drawing.Size(81, 22);
            this.txtValorServ.TabIndex = 9;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(452, 66);
            this.lblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(114, 16);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "Valor do serviço:";
            // 
            // lblFormPag
            // 
            this.lblFormPag.AutoSize = true;
            this.lblFormPag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPag.Location = new System.Drawing.Point(15, 29);
            this.lblFormPag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormPag.Name = "lblFormPag";
            this.lblFormPag.Size = new System.Drawing.Size(149, 16);
            this.lblFormPag.TabIndex = 18;
            this.lblFormPag.Text = "Forma de pagamento:";
            // 
            // lblFormLoc
            // 
            this.lblFormLoc.AutoSize = true;
            this.lblFormLoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormLoc.Location = new System.Drawing.Point(37, 69);
            this.lblFormLoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFormLoc.Name = "lblFormLoc";
            this.lblFormLoc.Size = new System.Drawing.Size(127, 16);
            this.lblFormLoc.TabIndex = 17;
            this.lblFormLoc.Text = "Forma de locação:";
            // 
            // cmbFormLoc
            // 
            this.cmbFormLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFormLoc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormLoc.FormattingEnabled = true;
            this.cmbFormLoc.Items.AddRange(new object[] {
            "KM Livre",
            "KM Determinada"});
            this.cmbFormLoc.Location = new System.Drawing.Point(179, 66);
            this.cmbFormLoc.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFormLoc.Name = "cmbFormLoc";
            this.cmbFormLoc.Size = new System.Drawing.Size(217, 24);
            this.cmbFormLoc.TabIndex = 8;
            // 
            // cmbFormPag
            // 
            this.cmbFormPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFormPag.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormPag.FormattingEnabled = true;
            this.cmbFormPag.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Débito",
            "Dinheiro/A vista"});
            this.cmbFormPag.Location = new System.Drawing.Point(179, 26);
            this.cmbFormPag.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFormPag.Name = "cmbFormPag";
            this.cmbFormPag.Size = new System.Drawing.Size(217, 24);
            this.cmbFormPag.TabIndex = 7;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucao.Location = new System.Drawing.Point(50, 151);
            this.lblDevolucao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(111, 16);
            this.lblDevolucao.TabIndex = 14;
            this.lblDevolucao.Text = "Data devolução:";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Location = new System.Drawing.Point(179, 146);
            this.dtpDevolucao.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(273, 23);
            this.dtpDevolucao.TabIndex = 11;
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLocacao.Location = new System.Drawing.Point(179, 107);
            this.dtpLocacao.Margin = new System.Windows.Forms.Padding(5);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(273, 23);
            this.dtpLocacao.TabIndex = 10;
            // 
            // lblLocacao
            // 
            this.lblLocacao.AutoSize = true;
            this.lblLocacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocacao.Location = new System.Drawing.Point(66, 113);
            this.lblLocacao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocacao.Name = "lblLocacao";
            this.lblLocacao.Size = new System.Drawing.Size(95, 16);
            this.lblLocacao.TabIndex = 11;
            this.lblLocacao.Text = "Data locação:";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(16, 142);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(794, 201);
            this.gridView.TabIndex = 14;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // txtCodFis
            // 
            this.txtCodFis.Location = new System.Drawing.Point(67, 27);
            this.txtCodFis.Name = "txtCodFis";
            this.txtCodFis.Size = new System.Drawing.Size(66, 22);
            this.txtCodFis.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 22);
            this.txtNome.TabIndex = 16;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(66, 87);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(308, 22);
            this.txtCpf.TabIndex = 17;
            // 
            // txtCodJur
            // 
            this.txtCodJur.Location = new System.Drawing.Point(107, 27);
            this.txtCodJur.Name = "txtCodJur";
            this.txtCodJur.Size = new System.Drawing.Size(66, 22);
            this.txtCodJur.TabIndex = 18;
            this.txtCodJur.Visible = false;
            // 
            // txtRazSoc
            // 
            this.txtRazSoc.Location = new System.Drawing.Point(107, 56);
            this.txtRazSoc.Name = "txtRazSoc";
            this.txtRazSoc.Size = new System.Drawing.Size(307, 22);
            this.txtRazSoc.TabIndex = 19;
            this.txtRazSoc.Visible = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(107, 85);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(307, 22);
            this.txtCnpj.TabIndex = 20;
            this.txtCnpj.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "CPF:";
            // 
            // grbPessoaF
            // 
            this.grbPessoaF.Controls.Add(this.label1);
            this.grbPessoaF.Controls.Add(this.label3);
            this.grbPessoaF.Controls.Add(this.txtCodFis);
            this.grbPessoaF.Controls.Add(this.label2);
            this.grbPessoaF.Controls.Add(this.txtCpf);
            this.grbPessoaF.Controls.Add(this.txtNome);
            this.grbPessoaF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPessoaF.Location = new System.Drawing.Point(16, 349);
            this.grbPessoaF.Name = "grbPessoaF";
            this.grbPessoaF.Size = new System.Drawing.Size(395, 121);
            this.grbPessoaF.TabIndex = 24;
            this.grbPessoaF.TabStop = false;
            this.grbPessoaF.Text = "Pessoa Física";
            // 
            // grbPessoaJ
            // 
            this.grbPessoaJ.Controls.Add(this.label6);
            this.grbPessoaJ.Controls.Add(this.label5);
            this.grbPessoaJ.Controls.Add(this.txtCnpj);
            this.grbPessoaJ.Controls.Add(this.label4);
            this.grbPessoaJ.Controls.Add(this.txtRazSoc);
            this.grbPessoaJ.Controls.Add(this.txtCodJur);
            this.grbPessoaJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPessoaJ.Location = new System.Drawing.Point(16, 349);
            this.grbPessoaJ.Name = "grbPessoaJ";
            this.grbPessoaJ.Size = new System.Drawing.Size(431, 121);
            this.grbPessoaJ.TabIndex = 25;
            this.grbPessoaJ.TabStop = false;
            this.grbPessoaJ.Text = "Pessoa Juridica";
            this.grbPessoaJ.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "CNPJ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Razão Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.txtCodCheckin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(471, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 146);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículo";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Indisponivel"});
            this.cmbStatus.Location = new System.Drawing.Point(67, 114);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(67, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(266, 22);
            this.txtModelo.TabIndex = 6;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(67, 56);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 22);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtCodCheckin
            // 
            this.txtCodCheckin.Location = new System.Drawing.Point(67, 27);
            this.txtCodCheckin.Name = "txtCodCheckin";
            this.txtCodCheckin.Size = new System.Drawing.Size(66, 22);
            this.txtCodCheckin.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Modelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Placa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código:";
            // 
            // btnRealizarCheckin
            // 
            this.btnRealizarCheckin.BackColor = System.Drawing.Color.White;
            this.btnRealizarCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarCheckin.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCheckin.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarCheckin.Image")));
            this.btnRealizarCheckin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizarCheckin.Location = new System.Drawing.Point(673, 15);
            this.btnRealizarCheckin.Margin = new System.Windows.Forms.Padding(5);
            this.btnRealizarCheckin.Name = "btnRealizarCheckin";
            this.btnRealizarCheckin.Size = new System.Drawing.Size(138, 72);
            this.btnRealizarCheckin.TabIndex = 3;
            this.btnRealizarCheckin.Text = "Realizar Checkin";
            this.btnRealizarCheckin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizarCheckin.UseVisualStyleBackColor = false;
            this.btnRealizarCheckin.Click += new System.EventHandler(this.btnRealizarCheckin_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(123, 15);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 53);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(16, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 53);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnCancelaAluguelAutomovel
            // 
            this.BtnCancelaAluguelAutomovel.BackColor = System.Drawing.Color.White;
            this.BtnCancelaAluguelAutomovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelaAluguelAutomovel.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelaAluguelAutomovel.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelaAluguelAutomovel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelaAluguelAutomovel.Image")));
            this.BtnCancelaAluguelAutomovel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelaAluguelAutomovel.Location = new System.Drawing.Point(231, 15);
            this.BtnCancelaAluguelAutomovel.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelaAluguelAutomovel.Name = "BtnCancelaAluguelAutomovel";
            this.BtnCancelaAluguelAutomovel.Size = new System.Drawing.Size(81, 53);
            this.BtnCancelaAluguelAutomovel.TabIndex = 2;
            this.BtnCancelaAluguelAutomovel.Text = "Cancelar";
            this.BtnCancelaAluguelAutomovel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelaAluguelAutomovel.UseVisualStyleBackColor = false;
            this.BtnCancelaAluguelAutomovel.Click += new System.EventHandler(this.BtnCancelaAluguelAutomovel_Click);
            // 
            // AluguelAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbPessoaJ);
            this.Controls.Add(this.grbPessoaF);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnRealizarCheckin);
            this.Controls.Add(this.grbOpcaoLoc);
            this.Controls.Add(this.grbCli);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.BtnCancelaAluguelAutomovel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AluguelAutomovel";
            this.Text = "Aluguel de Automoveis";
            this.Load += new System.EventHandler(this.AluguelAutomovel_Load);
            this.grbCli.ResumeLayout(false);
            this.grbveiculos.ResumeLayout(false);
            this.grbveiculos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbOpcaoLoc.ResumeLayout(false);
            this.grbOpcaoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.grbPessoaF.ResumeLayout(false);
            this.grbPessoaF.PerformLayout();
            this.grbPessoaJ.ResumeLayout(false);
            this.grbPessoaJ.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaAluguelAutomovel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grbCli;
        private System.Windows.Forms.GroupBox grbOpcaoLoc;
        private System.Windows.Forms.Label lblLocacao;
        private System.Windows.Forms.Button btnRealizarCheckin;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.Label lblFormPag;
        private System.Windows.Forms.Label lblFormLoc;
        private System.Windows.Forms.ComboBox cmbFormLoc;
        private System.Windows.Forms.ComboBox cmbFormPag;
        private System.Windows.Forms.TextBox txtValorServ;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtPessoaF;
        private System.Windows.Forms.RadioButton rbtPessoaJ;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txtCodFis;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCodJur;
        private System.Windows.Forms.TextBox txtRazSoc;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbPessoaF;
        private System.Windows.Forms.GroupBox grbPessoaJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtVeiculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCodCheckin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbveiculos;
    }
}