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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodFis = new System.Windows.Forms.Label();
            this.lblDta_Loc_Fis = new System.Windows.Forms.Label();
            this.lblDta_Dev_Fis = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.rbtPessoaJur = new System.Windows.Forms.RadioButton();
            this.rbtPessoaFis = new System.Windows.Forms.RadioButton();
            this.grbLocFisico = new System.Windows.Forms.GroupBox();
            this.txtCheckinFis = new System.Windows.Forms.TextBox();
            this.lblCheckinFis = new System.Windows.Forms.Label();
            this.lblValorFis = new System.Windows.Forms.Label();
            this.txtValorFis = new System.Windows.Forms.TextBox();
            this.txtStatusFis = new System.Windows.Forms.TextBox();
            this.txtCodFis = new System.Windows.Forms.TextBox();
            this.grbLocJuridico = new System.Windows.Forms.GroupBox();
            this.txtStatusJur = new System.Windows.Forms.TextBox();
            this.txtValorJur = new System.Windows.Forms.TextBox();
            this.txtCodJur = new System.Windows.Forms.TextBox();
            this.lblStatusJur = new System.Windows.Forms.Label();
            this.lblValorJur = new System.Windows.Forms.Label();
            this.lblDta_Dev_Jur = new System.Windows.Forms.Label();
            this.lblDta_Loc_Jur = new System.Windows.Forms.Label();
            this.lblCodJur = new System.Windows.Forms.Label();
            this.txtCheckinJur = new System.Windows.Forms.TextBox();
            this.lblCheckinJur = new System.Windows.Forms.Label();
            this.dtpDtaDevFis = new System.Windows.Forms.DateTimePicker();
            this.dtpDtaLocFis = new System.Windows.Forms.DateTimePicker();
            this.dtpDtaLocJur = new System.Windows.Forms.DateTimePicker();
            this.dtpDtaDevJur = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.grbBusca.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.BtnCancelaDevolucaoAutomovel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelaDevolucaoAutomovel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelaDevolucaoAutomovel.Image")));
            this.BtnCancelaDevolucaoAutomovel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelaDevolucaoAutomovel.Location = new System.Drawing.Point(229, 13);
            this.BtnCancelaDevolucaoAutomovel.Name = "BtnCancelaDevolucaoAutomovel";
            this.BtnCancelaDevolucaoAutomovel.Size = new System.Drawing.Size(81, 53);
            this.BtnCancelaDevolucaoAutomovel.TabIndex = 6;
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
            this.gridView.Location = new System.Drawing.Point(12, 149);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(794, 201);
            this.gridView.TabIndex = 7;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(12, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 53);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(118, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 53);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.groupBox2);
            this.grbBusca.Controls.Add(this.groupBox1);
            this.grbBusca.Location = new System.Drawing.Point(13, 72);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(485, 67);
            this.grbBusca.TabIndex = 10;
            this.grbBusca.TabStop = false;
            this.grbBusca.Text = "Buscar por";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(205, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 37);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblCodFis
            // 
            this.lblCodFis.AutoSize = true;
            this.lblCodFis.Location = new System.Drawing.Point(14, 29);
            this.lblCodFis.Name = "lblCodFis";
            this.lblCodFis.Size = new System.Drawing.Size(43, 13);
            this.lblCodFis.TabIndex = 12;
            this.lblCodFis.Text = "Código:";
            // 
            // lblDta_Loc_Fis
            // 
            this.lblDta_Loc_Fis.AutoSize = true;
            this.lblDta_Loc_Fis.Location = new System.Drawing.Point(16, 58);
            this.lblDta_Loc_Fis.Name = "lblDta_Loc_Fis";
            this.lblDta_Loc_Fis.Size = new System.Drawing.Size(78, 13);
            this.lblDta_Loc_Fis.TabIndex = 13;
            this.lblDta_Loc_Fis.Text = "Data Locação:";
            // 
            // lblDta_Dev_Fis
            // 
            this.lblDta_Dev_Fis.AutoSize = true;
            this.lblDta_Dev_Fis.Location = new System.Drawing.Point(6, 87);
            this.lblDta_Dev_Fis.Name = "lblDta_Dev_Fis";
            this.lblDta_Dev_Fis.Size = new System.Drawing.Size(88, 13);
            this.lblDta_Dev_Fis.TabIndex = 14;
            this.lblDta_Dev_Fis.Text = "Data Devolução:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.rbtPessoaJur);
            this.grbCliente.Controls.Add(this.rbtPessoaFis);
            this.grbCliente.Location = new System.Drawing.Point(554, 37);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(263, 57);
            this.grbCliente.TabIndex = 16;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // rbtPessoaJur
            // 
            this.rbtPessoaJur.AutoSize = true;
            this.rbtPessoaJur.Location = new System.Drawing.Point(143, 30);
            this.rbtPessoaJur.Name = "rbtPessoaJur";
            this.rbtPessoaJur.Size = new System.Drawing.Size(99, 17);
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
            this.rbtPessoaFis.Size = new System.Drawing.Size(90, 17);
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
            this.grbLocFisico.Location = new System.Drawing.Point(12, 363);
            this.grbLocFisico.Name = "grbLocFisico";
            this.grbLocFisico.Size = new System.Drawing.Size(396, 316);
            this.grbLocFisico.TabIndex = 17;
            this.grbLocFisico.TabStop = false;
            this.grbLocFisico.Text = "Locação Pessoa Fisica";
            // 
            // txtCheckinFis
            // 
            this.txtCheckinFis.Location = new System.Drawing.Point(106, 271);
            this.txtCheckinFis.Name = "txtCheckinFis";
            this.txtCheckinFis.Size = new System.Drawing.Size(100, 20);
            this.txtCheckinFis.TabIndex = 23;
            // 
            // lblCheckinFis
            // 
            this.lblCheckinFis.AutoSize = true;
            this.lblCheckinFis.Location = new System.Drawing.Point(6, 274);
            this.lblCheckinFis.Name = "lblCheckinFis";
            this.lblCheckinFis.Size = new System.Drawing.Size(85, 13);
            this.lblCheckinFis.TabIndex = 22;
            this.lblCheckinFis.Text = "Código Checkin:";
            // 
            // lblValorFis
            // 
            this.lblValorFis.AutoSize = true;
            this.lblValorFis.Location = new System.Drawing.Point(21, 171);
            this.lblValorFis.Name = "lblValorFis";
            this.lblValorFis.Size = new System.Drawing.Size(34, 13);
            this.lblValorFis.TabIndex = 21;
            this.lblValorFis.Text = "Valor:";
            // 
            // txtValorFis
            // 
            this.txtValorFis.Location = new System.Drawing.Point(106, 171);
            this.txtValorFis.Name = "txtValorFis";
            this.txtValorFis.Size = new System.Drawing.Size(100, 20);
            this.txtValorFis.TabIndex = 20;
            // 
            // txtStatusFis
            // 
            this.txtStatusFis.Location = new System.Drawing.Point(106, 236);
            this.txtStatusFis.Name = "txtStatusFis";
            this.txtStatusFis.Size = new System.Drawing.Size(100, 20);
            this.txtStatusFis.TabIndex = 17;
            // 
            // txtCodFis
            // 
            this.txtCodFis.Location = new System.Drawing.Point(106, 29);
            this.txtCodFis.Name = "txtCodFis";
            this.txtCodFis.Size = new System.Drawing.Size(100, 20);
            this.txtCodFis.TabIndex = 16;
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
            this.grbLocJuridico.Location = new System.Drawing.Point(580, 392);
            this.grbLocJuridico.Name = "grbLocJuridico";
            this.grbLocJuridico.Size = new System.Drawing.Size(397, 299);
            this.grbLocJuridico.TabIndex = 18;
            this.grbLocJuridico.TabStop = false;
            this.grbLocJuridico.Text = "Locação Pessoa Juridica";
            // 
            // txtStatusJur
            // 
            this.txtStatusJur.Location = new System.Drawing.Point(120, 146);
            this.txtStatusJur.Name = "txtStatusJur";
            this.txtStatusJur.Size = new System.Drawing.Size(100, 20);
            this.txtStatusJur.TabIndex = 9;
            // 
            // txtValorJur
            // 
            this.txtValorJur.Location = new System.Drawing.Point(120, 120);
            this.txtValorJur.Name = "txtValorJur";
            this.txtValorJur.Size = new System.Drawing.Size(100, 20);
            this.txtValorJur.TabIndex = 8;
            // 
            // txtCodJur
            // 
            this.txtCodJur.Location = new System.Drawing.Point(120, 34);
            this.txtCodJur.Name = "txtCodJur";
            this.txtCodJur.Size = new System.Drawing.Size(100, 20);
            this.txtCodJur.TabIndex = 5;
            // 
            // lblStatusJur
            // 
            this.lblStatusJur.AutoSize = true;
            this.lblStatusJur.Location = new System.Drawing.Point(28, 149);
            this.lblStatusJur.Name = "lblStatusJur";
            this.lblStatusJur.Size = new System.Drawing.Size(40, 13);
            this.lblStatusJur.TabIndex = 4;
            this.lblStatusJur.Text = "Status:";
            // 
            // lblValorJur
            // 
            this.lblValorJur.AutoSize = true;
            this.lblValorJur.Location = new System.Drawing.Point(28, 120);
            this.lblValorJur.Name = "lblValorJur";
            this.lblValorJur.Size = new System.Drawing.Size(34, 13);
            this.lblValorJur.TabIndex = 3;
            this.lblValorJur.Text = "Valor:";
            // 
            // lblDta_Dev_Jur
            // 
            this.lblDta_Dev_Jur.AutoSize = true;
            this.lblDta_Dev_Jur.Location = new System.Drawing.Point(28, 92);
            this.lblDta_Dev_Jur.Name = "lblDta_Dev_Jur";
            this.lblDta_Dev_Jur.Size = new System.Drawing.Size(88, 13);
            this.lblDta_Dev_Jur.TabIndex = 2;
            this.lblDta_Dev_Jur.Text = "Data Devolução:";
            // 
            // lblDta_Loc_Jur
            // 
            this.lblDta_Loc_Jur.AutoSize = true;
            this.lblDta_Loc_Jur.Location = new System.Drawing.Point(28, 63);
            this.lblDta_Loc_Jur.Name = "lblDta_Loc_Jur";
            this.lblDta_Loc_Jur.Size = new System.Drawing.Size(78, 13);
            this.lblDta_Loc_Jur.TabIndex = 1;
            this.lblDta_Loc_Jur.Text = "Data Locação:";
            // 
            // lblCodJur
            // 
            this.lblCodJur.AutoSize = true;
            this.lblCodJur.Location = new System.Drawing.Point(28, 34);
            this.lblCodJur.Name = "lblCodJur";
            this.lblCodJur.Size = new System.Drawing.Size(43, 13);
            this.lblCodJur.TabIndex = 0;
            this.lblCodJur.Text = "Código:";
            // 
            // txtCheckinJur
            // 
            this.txtCheckinJur.Location = new System.Drawing.Point(120, 187);
            this.txtCheckinJur.Name = "txtCheckinJur";
            this.txtCheckinJur.Size = new System.Drawing.Size(100, 20);
            this.txtCheckinJur.TabIndex = 10;
            // 
            // lblCheckinJur
            // 
            this.lblCheckinJur.AutoSize = true;
            this.lblCheckinJur.Location = new System.Drawing.Point(21, 194);
            this.lblCheckinJur.Name = "lblCheckinJur";
            this.lblCheckinJur.Size = new System.Drawing.Size(85, 13);
            this.lblCheckinJur.TabIndex = 11;
            this.lblCheckinJur.Text = "Código Checkin:";
            // 
            // dtpDtaDevFis
            // 
            this.dtpDtaDevFis.Location = new System.Drawing.Point(106, 85);
            this.dtpDtaDevFis.Name = "dtpDtaDevFis";
            this.dtpDtaDevFis.Size = new System.Drawing.Size(223, 20);
            this.dtpDtaDevFis.TabIndex = 26;
            // 
            // dtpDtaLocFis
            // 
            this.dtpDtaLocFis.Location = new System.Drawing.Point(105, 58);
            this.dtpDtaLocFis.Name = "dtpDtaLocFis";
            this.dtpDtaLocFis.Size = new System.Drawing.Size(217, 20);
            this.dtpDtaLocFis.TabIndex = 27;
            // 
            // dtpDtaLocJur
            // 
            this.dtpDtaLocJur.Location = new System.Drawing.Point(122, 64);
            this.dtpDtaLocJur.Name = "dtpDtaLocJur";
            this.dtpDtaLocJur.Size = new System.Drawing.Size(241, 20);
            this.dtpDtaLocJur.TabIndex = 12;
            // 
            // dtpDtaDevJur
            // 
            this.dtpDtaDevJur.Location = new System.Drawing.Point(124, 95);
            this.dtpDtaDevJur.Name = "dtpDtaDevJur";
            this.dtpDtaDevJur.Size = new System.Drawing.Size(239, 20);
            this.dtpDtaDevJur.TabIndex = 13;
            // 
            // DevolucaoAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 716);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
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