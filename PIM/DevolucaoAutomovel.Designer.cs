namespace PIM
{
    partial class DevolucaoAutomovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucaoAutomovel));
            this.BtnCancelaDevolucaoAutomovel = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grbBusca = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaCod = new System.Windows.Forms.TextBox();
            this.lblCodFis = new System.Windows.Forms.Label();
            this.lblDta_Loc_Fis = new System.Windows.Forms.Label();
            this.lblDta_Dev_Fis = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.rbtPessoaJur = new System.Windows.Forms.RadioButton();
            this.rbtPessoaFis = new System.Windows.Forms.RadioButton();
            this.grbLocFisico = new System.Windows.Forms.GroupBox();
            this.dtpDtaLocFis = new System.Windows.Forms.DateTimePicker();
            this.dtpDtaDevFis = new System.Windows.Forms.DateTimePicker();
            this.txtCheckinFis = new System.Windows.Forms.TextBox();
            this.lblCheckinFis = new System.Windows.Forms.Label();
            this.lblValorFis = new System.Windows.Forms.Label();
            this.txtValorFis = new System.Windows.Forms.TextBox();
            this.txtStatusFis = new System.Windows.Forms.TextBox();
            this.txtCodFis = new System.Windows.Forms.TextBox();
            this.grbLocJuridico = new System.Windows.Forms.GroupBox();
            this.dtpDtaDevJur = new System.Windows.Forms.DateTimePicker();
            this.dtpDtaLocJur = new System.Windows.Forms.DateTimePicker();
            this.lblCheckinJur = new System.Windows.Forms.Label();
            this.txtCheckinJur = new System.Windows.Forms.TextBox();
            this.txtStatusJur = new System.Windows.Forms.TextBox();
            this.txtValorJur = new System.Windows.Forms.TextBox();
            this.txtCodJur = new System.Windows.Forms.TextBox();
            this.lblStatusJur = new System.Windows.Forms.Label();
            this.lblValorJur = new System.Windows.Forms.Label();
            this.lblDta_Dev_Jur = new System.Windows.Forms.Label();
            this.lblDta_Loc_Jur = new System.Windows.Forms.Label();
            this.lblCodJur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.grbBusca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbCliente.SuspendLayout();
            this.grbLocFisico.SuspendLayout();
            this.grbLocJuridico.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelaDevolucaoAutomovel
            // 
            this.BtnCancelaDevolucaoAutomovel.BackColor = System.Drawing.Color.White;
            this.BtnCancelaDevolucaoAutomovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelaDevolucaoAutomovel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelaDevolucaoAutomovel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelaDevolucaoAutomovel.Image")));
            this.BtnCancelaDevolucaoAutomovel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelaDevolucaoAutomovel.Location = new System.Drawing.Point(229, 13);
            this.BtnCancelaDevolucaoAutomovel.Name = "BtnCancelaDevolucaoAutomovel";
            this.BtnCancelaDevolucaoAutomovel.Size = new System.Drawing.Size(81, 53);
            this.BtnCancelaDevolucaoAutomovel.TabIndex = 2;
            this.BtnCancelaDevolucaoAutomovel.Text = "Cancelar";
            this.BtnCancelaDevolucaoAutomovel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelaDevolucaoAutomovel.UseVisualStyleBackColor = false;
            this.BtnCancelaDevolucaoAutomovel.Click += new System.EventHandler(this.BtnCancelaDevolucaoAutomovel_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 165);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(794, 201);
            this.gridView.TabIndex = 7;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(12, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 53);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(118, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 53);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.groupBox1);
            this.grbBusca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusca.Location = new System.Drawing.Point(13, 72);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(186, 87);
            this.grbBusca.TabIndex = 10;
            this.grbBusca.TabStop = false;
            this.grbBusca.Text = "Buscar por";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaCod);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código";
            // 
            // txtBuscaCod
            // 
            this.txtBuscaCod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCod.Location = new System.Drawing.Point(17, 20);
            this.txtBuscaCod.Name = "txtBuscaCod";
            this.txtBuscaCod.Size = new System.Drawing.Size(100, 22);
            this.txtBuscaCod.TabIndex = 3;
            this.txtBuscaCod.TextChanged += new System.EventHandler(this.txtBuscaCod_TextChanged_1);
            // 
            // lblCodFis
            // 
            this.lblCodFis.AutoSize = true;
            this.lblCodFis.Location = new System.Drawing.Point(61, 32);
            this.lblCodFis.Name = "lblCodFis";
            this.lblCodFis.Size = new System.Drawing.Size(57, 16);
            this.lblCodFis.TabIndex = 12;
            this.lblCodFis.Text = "Código:";
            // 
            // lblDta_Loc_Fis
            // 
            this.lblDta_Loc_Fis.AutoSize = true;
            this.lblDta_Loc_Fis.Location = new System.Drawing.Point(19, 66);
            this.lblDta_Loc_Fis.Name = "lblDta_Loc_Fis";
            this.lblDta_Loc_Fis.Size = new System.Drawing.Size(99, 16);
            this.lblDta_Loc_Fis.TabIndex = 13;
            this.lblDta_Loc_Fis.Text = "Data Locação:";
            // 
            // lblDta_Dev_Fis
            // 
            this.lblDta_Dev_Fis.AutoSize = true;
            this.lblDta_Dev_Fis.Location = new System.Drawing.Point(6, 98);
            this.lblDta_Dev_Fis.Name = "lblDta_Dev_Fis";
            this.lblDta_Dev_Fis.Size = new System.Drawing.Size(112, 16);
            this.lblDta_Dev_Fis.TabIndex = 14;
            this.lblDta_Dev_Fis.Text = "Data Devolução:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(64, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.rbtPessoaJur);
            this.grbCliente.Controls.Add(this.rbtPessoaFis);
            this.grbCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(504, 7);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(302, 57);
            this.grbCliente.TabIndex = 5;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // rbtPessoaJur
            // 
            this.rbtPessoaJur.AutoSize = true;
            this.rbtPessoaJur.Location = new System.Drawing.Point(143, 30);
            this.rbtPessoaJur.Name = "rbtPessoaJur";
            this.rbtPessoaJur.Size = new System.Drawing.Size(126, 20);
            this.rbtPessoaJur.TabIndex = 1;
            this.rbtPessoaJur.Text = "Pessoa Juridica";
            this.rbtPessoaJur.UseVisualStyleBackColor = true;
            this.rbtPessoaJur.CheckedChanged += new System.EventHandler(this.rbtPessoaJur_CheckedChanged);
            // 
            // rbtPessoaFis
            // 
            this.rbtPessoaFis.AutoSize = true;
            this.rbtPessoaFis.Checked = true;
            this.rbtPessoaFis.Location = new System.Drawing.Point(26, 30);
            this.rbtPessoaFis.Name = "rbtPessoaFis";
            this.rbtPessoaFis.Size = new System.Drawing.Size(112, 20);
            this.rbtPessoaFis.TabIndex = 0;
            this.rbtPessoaFis.TabStop = true;
            this.rbtPessoaFis.Text = "Pessoa Fisica";
            this.rbtPessoaFis.UseVisualStyleBackColor = true;
            this.rbtPessoaFis.CheckedChanged += new System.EventHandler(this.rbtPessoaFis_CheckedChanged);
            // 
            // grbLocFisico
            // 
            this.grbLocFisico.Controls.Add(this.dtpDtaLocFis);
            this.grbLocFisico.Controls.Add(this.dtpDtaDevFis);
            this.grbLocFisico.Controls.Add(this.txtCheckinFis);
            this.grbLocFisico.Controls.Add(this.lblCheckinFis);
            this.grbLocFisico.Controls.Add(this.lblValorFis);
            this.grbLocFisico.Controls.Add(this.txtValorFis);
            this.grbLocFisico.Controls.Add(this.txtStatusFis);
            this.grbLocFisico.Controls.Add(this.txtCodFis);
            this.grbLocFisico.Controls.Add(this.lblCodFis);
            this.grbLocFisico.Controls.Add(this.lblStatus);
            this.grbLocFisico.Controls.Add(this.lblDta_Loc_Fis);
            this.grbLocFisico.Controls.Add(this.lblDta_Dev_Fis);
            this.grbLocFisico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocFisico.Location = new System.Drawing.Point(12, 378);
            this.grbLocFisico.Name = "grbLocFisico";
            this.grbLocFisico.Size = new System.Drawing.Size(396, 244);
            this.grbLocFisico.TabIndex = 17;
            this.grbLocFisico.TabStop = false;
            this.grbLocFisico.Text = "Locação Pessoa Fisica";
            // 
            // dtpDtaLocFis
            // 
            this.dtpDtaLocFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtaLocFis.Location = new System.Drawing.Point(121, 63);
            this.dtpDtaLocFis.Name = "dtpDtaLocFis";
            this.dtpDtaLocFis.Size = new System.Drawing.Size(269, 22);
            this.dtpDtaLocFis.TabIndex = 1;
            // 
            // dtpDtaDevFis
            // 
            this.dtpDtaDevFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtaDevFis.Location = new System.Drawing.Point(121, 96);
            this.dtpDtaDevFis.Name = "dtpDtaDevFis";
            this.dtpDtaDevFis.Size = new System.Drawing.Size(269, 22);
            this.dtpDtaDevFis.TabIndex = 2;
            // 
            // txtCheckinFis
            // 
            this.txtCheckinFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckinFis.Location = new System.Drawing.Point(121, 197);
            this.txtCheckinFis.Name = "txtCheckinFis";
            this.txtCheckinFis.Size = new System.Drawing.Size(100, 22);
            this.txtCheckinFis.TabIndex = 5;
            // 
            // lblCheckinFis
            // 
            this.lblCheckinFis.AutoSize = true;
            this.lblCheckinFis.Location = new System.Drawing.Point(3, 200);
            this.lblCheckinFis.Name = "lblCheckinFis";
            this.lblCheckinFis.Size = new System.Drawing.Size(112, 16);
            this.lblCheckinFis.TabIndex = 22;
            this.lblCheckinFis.Text = "Código Checkin:";
            // 
            // lblValorFis
            // 
            this.lblValorFis.AutoSize = true;
            this.lblValorFis.Location = new System.Drawing.Point(70, 132);
            this.lblValorFis.Name = "lblValorFis";
            this.lblValorFis.Size = new System.Drawing.Size(45, 16);
            this.lblValorFis.TabIndex = 21;
            this.lblValorFis.Text = "Valor:";
            // 
            // txtValorFis
            // 
            this.txtValorFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFis.Location = new System.Drawing.Point(121, 129);
            this.txtValorFis.Name = "txtValorFis";
            this.txtValorFis.Size = new System.Drawing.Size(100, 22);
            this.txtValorFis.TabIndex = 3;
            // 
            // txtStatusFis
            // 
            this.txtStatusFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusFis.Location = new System.Drawing.Point(121, 163);
            this.txtStatusFis.Name = "txtStatusFis";
            this.txtStatusFis.Size = new System.Drawing.Size(100, 22);
            this.txtStatusFis.TabIndex = 4;
            // 
            // txtCodFis
            // 
            this.txtCodFis.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFis.Location = new System.Drawing.Point(121, 29);
            this.txtCodFis.Name = "txtCodFis";
            this.txtCodFis.Size = new System.Drawing.Size(100, 22);
            this.txtCodFis.TabIndex = 0;
            // 
            // grbLocJuridico
            // 
            this.grbLocJuridico.Controls.Add(this.dtpDtaDevJur);
            this.grbLocJuridico.Controls.Add(this.dtpDtaLocJur);
            this.grbLocJuridico.Controls.Add(this.lblCheckinJur);
            this.grbLocJuridico.Controls.Add(this.txtCheckinJur);
            this.grbLocJuridico.Controls.Add(this.txtStatusJur);
            this.grbLocJuridico.Controls.Add(this.txtValorJur);
            this.grbLocJuridico.Controls.Add(this.txtCodJur);
            this.grbLocJuridico.Controls.Add(this.lblStatusJur);
            this.grbLocJuridico.Controls.Add(this.lblValorJur);
            this.grbLocJuridico.Controls.Add(this.lblDta_Dev_Jur);
            this.grbLocJuridico.Controls.Add(this.lblDta_Loc_Jur);
            this.grbLocJuridico.Controls.Add(this.lblCodJur);
            this.grbLocJuridico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocJuridico.Location = new System.Drawing.Point(12, 378);
            this.grbLocJuridico.Name = "grbLocJuridico";
            this.grbLocJuridico.Size = new System.Drawing.Size(396, 244);
            this.grbLocJuridico.TabIndex = 18;
            this.grbLocJuridico.TabStop = false;
            this.grbLocJuridico.Text = "Locação Pessoa Juridica";
            // 
            // dtpDtaDevJur
            // 
            this.dtpDtaDevJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtaDevJur.Location = new System.Drawing.Point(121, 96);
            this.dtpDtaDevJur.Name = "dtpDtaDevJur";
            this.dtpDtaDevJur.Size = new System.Drawing.Size(269, 22);
            this.dtpDtaDevJur.TabIndex = 2;
            // 
            // dtpDtaLocJur
            // 
            this.dtpDtaLocJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtaLocJur.Location = new System.Drawing.Point(121, 63);
            this.dtpDtaLocJur.Name = "dtpDtaLocJur";
            this.dtpDtaLocJur.Size = new System.Drawing.Size(269, 22);
            this.dtpDtaLocJur.TabIndex = 1;
            // 
            // lblCheckinJur
            // 
            this.lblCheckinJur.AutoSize = true;
            this.lblCheckinJur.Location = new System.Drawing.Point(3, 200);
            this.lblCheckinJur.Name = "lblCheckinJur";
            this.lblCheckinJur.Size = new System.Drawing.Size(112, 16);
            this.lblCheckinJur.TabIndex = 11;
            this.lblCheckinJur.Text = "Código Checkin:";
            // 
            // txtCheckinJur
            // 
            this.txtCheckinJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckinJur.Location = new System.Drawing.Point(121, 197);
            this.txtCheckinJur.Name = "txtCheckinJur";
            this.txtCheckinJur.Size = new System.Drawing.Size(100, 22);
            this.txtCheckinJur.TabIndex = 5;
            // 
            // txtStatusJur
            // 
            this.txtStatusJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusJur.Location = new System.Drawing.Point(121, 163);
            this.txtStatusJur.Name = "txtStatusJur";
            this.txtStatusJur.Size = new System.Drawing.Size(100, 22);
            this.txtStatusJur.TabIndex = 4;
            // 
            // txtValorJur
            // 
            this.txtValorJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorJur.Location = new System.Drawing.Point(121, 129);
            this.txtValorJur.Name = "txtValorJur";
            this.txtValorJur.Size = new System.Drawing.Size(100, 22);
            this.txtValorJur.TabIndex = 3;
            // 
            // txtCodJur
            // 
            this.txtCodJur.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodJur.Location = new System.Drawing.Point(121, 29);
            this.txtCodJur.Name = "txtCodJur";
            this.txtCodJur.Size = new System.Drawing.Size(100, 22);
            this.txtCodJur.TabIndex = 0;
            // 
            // lblStatusJur
            // 
            this.lblStatusJur.AutoSize = true;
            this.lblStatusJur.Location = new System.Drawing.Point(64, 166);
            this.lblStatusJur.Name = "lblStatusJur";
            this.lblStatusJur.Size = new System.Drawing.Size(51, 16);
            this.lblStatusJur.TabIndex = 4;
            this.lblStatusJur.Text = "Status:";
            // 
            // lblValorJur
            // 
            this.lblValorJur.AutoSize = true;
            this.lblValorJur.Location = new System.Drawing.Point(70, 132);
            this.lblValorJur.Name = "lblValorJur";
            this.lblValorJur.Size = new System.Drawing.Size(45, 16);
            this.lblValorJur.TabIndex = 3;
            this.lblValorJur.Text = "Valor:";
            // 
            // lblDta_Dev_Jur
            // 
            this.lblDta_Dev_Jur.AutoSize = true;
            this.lblDta_Dev_Jur.Location = new System.Drawing.Point(6, 98);
            this.lblDta_Dev_Jur.Name = "lblDta_Dev_Jur";
            this.lblDta_Dev_Jur.Size = new System.Drawing.Size(112, 16);
            this.lblDta_Dev_Jur.TabIndex = 2;
            this.lblDta_Dev_Jur.Text = "Data Devolução:";
            // 
            // lblDta_Loc_Jur
            // 
            this.lblDta_Loc_Jur.AutoSize = true;
            this.lblDta_Loc_Jur.Location = new System.Drawing.Point(19, 66);
            this.lblDta_Loc_Jur.Name = "lblDta_Loc_Jur";
            this.lblDta_Loc_Jur.Size = new System.Drawing.Size(99, 16);
            this.lblDta_Loc_Jur.TabIndex = 1;
            this.lblDta_Loc_Jur.Text = "Data Locação:";
            // 
            // lblCodJur
            // 
            this.lblCodJur.AutoSize = true;
            this.lblCodJur.Location = new System.Drawing.Point(61, 32);
            this.lblCodJur.Name = "lblCodJur";
            this.lblCodJur.Size = new System.Drawing.Size(57, 16);
            this.lblCodJur.TabIndex = 0;
            this.lblCodJur.Text = "Código:";
            // 
            // DevolucaoAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 716);
            this.Controls.Add(this.grbLocJuridico);
            this.Controls.Add(this.grbLocFisico);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbBusca);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.BtnCancelaDevolucaoAutomovel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolucaoAutomovel";
            this.Text = "Devolução de Automóveis";
            this.Load += new System.EventHandler(this.DevolucaoAutomovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.grbBusca.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbLocFisico.ResumeLayout(false);
            this.grbLocFisico.PerformLayout();
            this.grbLocJuridico.ResumeLayout(false);
            this.grbLocJuridico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaDevolucaoAutomovel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grbBusca;
        private System.Windows.Forms.TextBox txtBuscaCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodFis;
        private System.Windows.Forms.Label lblDta_Loc_Fis;
        private System.Windows.Forms.Label lblDta_Dev_Fis;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.RadioButton rbtPessoaFis;
        private System.Windows.Forms.RadioButton rbtPessoaJur;
        private System.Windows.Forms.GroupBox grbLocFisico;
        private System.Windows.Forms.TextBox txtCodFis;
        private System.Windows.Forms.Label lblValorFis;
        private System.Windows.Forms.TextBox txtValorFis;
        private System.Windows.Forms.TextBox txtStatusFis;
        private System.Windows.Forms.GroupBox grbLocJuridico;
        private System.Windows.Forms.TextBox txtStatusJur;
        private System.Windows.Forms.TextBox txtValorJur;
        private System.Windows.Forms.TextBox txtCodJur;
        private System.Windows.Forms.Label lblStatusJur;
        private System.Windows.Forms.Label lblValorJur;
        private System.Windows.Forms.Label lblDta_Dev_Jur;
        private System.Windows.Forms.Label lblDta_Loc_Jur;
        private System.Windows.Forms.Label lblCodJur;
        private System.Windows.Forms.TextBox txtCheckinFis;
        private System.Windows.Forms.Label lblCheckinFis;
        private System.Windows.Forms.Label lblCheckinJur;
        private System.Windows.Forms.TextBox txtCheckinJur;
        private System.Windows.Forms.DateTimePicker dtpDtaDevFis;
        private System.Windows.Forms.DateTimePicker dtpDtaLocFis;
        private System.Windows.Forms.DateTimePicker dtpDtaDevJur;
        private System.Windows.Forms.DateTimePicker dtpDtaLocJur;
    }
}