namespace PIM
{
    partial class LocalizarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarVeiculo));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.grbRenavam = new System.Windows.Forms.GroupBox();
            this.txtPesqRenavam = new System.Windows.Forms.TextBox();
            this.grbPlaca = new System.Windows.Forms.GroupBox();
            this.txtPesqPlaca = new System.Windows.Forms.TextBox();
            this.grbModel = new System.Windows.Forms.GroupBox();
            this.txtPesqModel = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.grbVeiculos = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbPortas = new System.Windows.Forms.ComboBox();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.cmbAnoM = new System.Windows.Forms.ComboBox();
            this.cmbAnoF = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.mskChassi = new System.Windows.Forms.MaskedTextBox();
            this.mskRenavam = new System.Windows.Forms.MaskedTextBox();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPortas = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblAnom = new System.Windows.Forms.Label();
            this.lblAnof = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.rbtVeiculo = new System.Windows.Forms.RadioButton();
            this.grbPesquisa.SuspendLayout();
            this.grbRenavam.SuspendLayout();
            this.grbPlaca.SuspendLayout();
            this.grbModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.grbVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 53);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(116, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 53);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.grbRenavam);
            this.grbPesquisa.Controls.Add(this.grbPlaca);
            this.grbPesquisa.Controls.Add(this.grbModel);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 82);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(800, 85);
            this.grbPesquisa.TabIndex = 2;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Busca por";
            // 
            // grbRenavam
            // 
            this.grbRenavam.Controls.Add(this.txtPesqRenavam);
            this.grbRenavam.Location = new System.Drawing.Point(459, 25);
            this.grbRenavam.Name = "grbRenavam";
            this.grbRenavam.Size = new System.Drawing.Size(169, 45);
            this.grbRenavam.TabIndex = 2;
            this.grbRenavam.TabStop = false;
            this.grbRenavam.Text = "Renavam";
            // 
            // txtPesqRenavam
            // 
            this.txtPesqRenavam.Location = new System.Drawing.Point(6, 16);
            this.txtPesqRenavam.Name = "txtPesqRenavam";
            this.txtPesqRenavam.Size = new System.Drawing.Size(145, 20);
            this.txtPesqRenavam.TabIndex = 18;
            this.txtPesqRenavam.TextChanged += new System.EventHandler(this.txtPesqRenavam_TextChanged);
            // 
            // grbPlaca
            // 
            this.grbPlaca.Controls.Add(this.txtPesqPlaca);
            this.grbPlaca.Location = new System.Drawing.Point(248, 25);
            this.grbPlaca.Name = "grbPlaca";
            this.grbPlaca.Size = new System.Drawing.Size(168, 45);
            this.grbPlaca.TabIndex = 1;
            this.grbPlaca.TabStop = false;
            this.grbPlaca.Text = "Placa";
            // 
            // txtPesqPlaca
            // 
            this.txtPesqPlaca.Location = new System.Drawing.Point(6, 16);
            this.txtPesqPlaca.Name = "txtPesqPlaca";
            this.txtPesqPlaca.Size = new System.Drawing.Size(145, 20);
            this.txtPesqPlaca.TabIndex = 17;
            this.txtPesqPlaca.TextChanged += new System.EventHandler(this.txtPesqPlaca_TextChanged);
            // 
            // grbModel
            // 
            this.grbModel.Controls.Add(this.txtPesqModel);
            this.grbModel.Location = new System.Drawing.Point(6, 25);
            this.grbModel.Name = "grbModel";
            this.grbModel.Size = new System.Drawing.Size(204, 45);
            this.grbModel.TabIndex = 0;
            this.grbModel.TabStop = false;
            this.grbModel.Text = "Modelo";
            // 
            // txtPesqModel
            // 
            this.txtPesqModel.Location = new System.Drawing.Point(6, 16);
            this.txtPesqModel.Name = "txtPesqModel";
            this.txtPesqModel.Size = new System.Drawing.Size(184, 20);
            this.txtPesqModel.TabIndex = 16;
            this.txtPesqModel.TextChanged += new System.EventHandler(this.txtPesqModel_TextChanged);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(14, 176);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(798, 178);
            this.datagrid.TabIndex = 3;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellClick);
            // 
            // grbVeiculos
            // 
            this.grbVeiculos.Controls.Add(this.cmbEstado);
            this.grbVeiculos.Controls.Add(this.cmbPortas);
            this.grbVeiculos.Controls.Add(this.cmbCor);
            this.grbVeiculos.Controls.Add(this.cmbTipo);
            this.grbVeiculos.Controls.Add(this.cmbCombustivel);
            this.grbVeiculos.Controls.Add(this.cmbAnoM);
            this.grbVeiculos.Controls.Add(this.cmbAnoF);
            this.grbVeiculos.Controls.Add(this.cmbMarca);
            this.grbVeiculos.Controls.Add(this.mskChassi);
            this.grbVeiculos.Controls.Add(this.mskRenavam);
            this.grbVeiculos.Controls.Add(this.mskPlaca);
            this.grbVeiculos.Controls.Add(this.lblObs);
            this.grbVeiculos.Controls.Add(this.lblCidade);
            this.grbVeiculos.Controls.Add(this.lblEstado);
            this.grbVeiculos.Controls.Add(this.lblKm);
            this.grbVeiculos.Controls.Add(this.lblTipo);
            this.grbVeiculos.Controls.Add(this.lblPortas);
            this.grbVeiculos.Controls.Add(this.lblCor);
            this.grbVeiculos.Controls.Add(this.lblCombustivel);
            this.grbVeiculos.Controls.Add(this.lblAnom);
            this.grbVeiculos.Controls.Add(this.lblAnof);
            this.grbVeiculos.Controls.Add(this.lblMarca);
            this.grbVeiculos.Controls.Add(this.txtModelo);
            this.grbVeiculos.Controls.Add(this.txtKm);
            this.grbVeiculos.Controls.Add(this.txtCidade);
            this.grbVeiculos.Controls.Add(this.txtObs);
            this.grbVeiculos.Controls.Add(this.txtCod);
            this.grbVeiculos.Controls.Add(this.lblModelo);
            this.grbVeiculos.Controls.Add(this.lblChassi);
            this.grbVeiculos.Controls.Add(this.lblRenavam);
            this.grbVeiculos.Controls.Add(this.lblPlaca);
            this.grbVeiculos.Controls.Add(this.lblCod);
            this.grbVeiculos.Location = new System.Drawing.Point(15, 368);
            this.grbVeiculos.Name = "grbVeiculos";
            this.grbVeiculos.Size = new System.Drawing.Size(796, 360);
            this.grbVeiculos.TabIndex = 4;
            this.grbVeiculos.TabStop = false;
            this.grbVeiculos.Text = "Dados do veiculo";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá ",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso ",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco ",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo ",
            "Sergipe",
            "Tocantins"});
            this.cmbEstado.Location = new System.Drawing.Point(570, 203);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(106, 24);
            this.cmbEstado.TabIndex = 14;
            // 
            // cmbPortas
            // 
            this.cmbPortas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortas.FormattingEnabled = true;
            this.cmbPortas.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5"});
            this.cmbPortas.Location = new System.Drawing.Point(603, 114);
            this.cmbPortas.Name = "cmbPortas";
            this.cmbPortas.Size = new System.Drawing.Size(73, 24);
            this.cmbPortas.TabIndex = 7;
            // 
            // cmbCor
            // 
            this.cmbCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Items.AddRange(new object[] {
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
            this.cmbCor.Location = new System.Drawing.Point(95, 172);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(156, 24);
            this.cmbCor.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
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
            this.cmbTipo.Location = new System.Drawing.Point(603, 143);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(73, 24);
            this.cmbTipo.TabIndex = 10;
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Items.AddRange(new object[] {
            "Diesel",
            "Etanol",
            "Flex",
            "Gaz",
            "Gasolina"});
            this.cmbCombustivel.Location = new System.Drawing.Point(95, 142);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(156, 24);
            this.cmbCombustivel.TabIndex = 8;
            // 
            // cmbAnoM
            // 
            this.cmbAnoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoM.FormattingEnabled = true;
            this.cmbAnoM.Items.AddRange(new object[] {
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
            this.cmbAnoM.Location = new System.Drawing.Point(603, 83);
            this.cmbAnoM.Name = "cmbAnoM";
            this.cmbAnoM.Size = new System.Drawing.Size(73, 24);
            this.cmbAnoM.TabIndex = 4;
            // 
            // cmbAnoF
            // 
            this.cmbAnoF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoF.FormattingEnabled = true;
            this.cmbAnoF.Items.AddRange(new object[] {
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
            this.cmbAnoF.Location = new System.Drawing.Point(603, 53);
            this.cmbAnoF.Name = "cmbAnoF";
            this.cmbAnoF.Size = new System.Drawing.Size(73, 24);
            this.cmbAnoF.TabIndex = 2;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
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
            this.cmbMarca.Location = new System.Drawing.Point(95, 83);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(365, 24);
            this.cmbMarca.TabIndex = 3;
            // 
            // mskChassi
            // 
            this.mskChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskChassi.Location = new System.Drawing.Point(315, 114);
            this.mskChassi.Mask = "00000000000000000";
            this.mskChassi.Name = "mskChassi";
            this.mskChassi.Size = new System.Drawing.Size(145, 23);
            this.mskChassi.TabIndex = 6;
            // 
            // mskRenavam
            // 
            this.mskRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRenavam.Location = new System.Drawing.Point(360, 172);
            this.mskRenavam.Mask = "00000000000";
            this.mskRenavam.Name = "mskRenavam";
            this.mskRenavam.Size = new System.Drawing.Size(100, 23);
            this.mskRenavam.TabIndex = 12;
            // 
            // mskPlaca
            // 
            this.mskPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPlaca.Location = new System.Drawing.Point(95, 114);
            this.mskPlaca.Mask = "AAA-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(84, 23);
            this.mskPlaca.TabIndex = 5;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(1, 229);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(89, 17);
            this.lblObs.TabIndex = 20;
            this.lblObs.Text = "Observacao:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(33, 205);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 19;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(510, 206);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(305, 146);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(32, 17);
            this.lblKm.TabIndex = 17;
            this.lblKm.Text = "KM:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(557, 145);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortas.Location = new System.Drawing.Point(544, 117);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(53, 17);
            this.lblPortas.TabIndex = 15;
            this.lblPortas.Text = "Portas:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(55, 174);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(34, 17);
            this.lblCor.TabIndex = 14;
            this.lblCor.Text = "Cor:";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(1, 145);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(88, 17);
            this.lblCombustivel.TabIndex = 13;
            this.lblCombustivel.Text = "Combustivel:";
            // 
            // lblAnom
            // 
            this.lblAnom.AutoSize = true;
            this.lblAnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnom.Location = new System.Drawing.Point(510, 86);
            this.lblAnom.Name = "lblAnom";
            this.lblAnom.Size = new System.Drawing.Size(87, 17);
            this.lblAnom.TabIndex = 12;
            this.lblAnom.Text = "Ano modelo:";
            // 
            // lblAnof
            // 
            this.lblAnof.AutoSize = true;
            this.lblAnof.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnof.Location = new System.Drawing.Point(521, 56);
            this.lblAnof.Name = "lblAnof";
            this.lblAnof.Size = new System.Drawing.Size(76, 17);
            this.lblAnof.TabIndex = 11;
            this.lblAnof.Text = "Ano fabric:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(38, 86);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(95, 54);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(365, 23);
            this.txtModelo.TabIndex = 1;
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(343, 142);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(117, 23);
            this.txtKm.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(95, 202);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(365, 23);
            this.txtCidade.TabIndex = 13;
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(95, 233);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(365, 95);
            this.txtObs.TabIndex = 15;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(95, 25);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(84, 23);
            this.txtCod.TabIndex = 0;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(31, 56);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 17);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassi.Location = new System.Drawing.Point(255, 117);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(54, 17);
            this.lblChassi.TabIndex = 3;
            this.lblChassi.Text = "Chassi:";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenavam.Location = new System.Drawing.Point(265, 179);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(72, 17);
            this.lblRenavam.TabIndex = 2;
            this.lblRenavam.Text = "Renavam:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(42, 117);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 17);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(33, 28);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(56, 17);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo:";
            // 
            // rbtVeiculo
            // 
            this.rbtVeiculo.AutoSize = true;
            this.rbtVeiculo.Checked = true;
            this.rbtVeiculo.Location = new System.Drawing.Point(247, 18);
            this.rbtVeiculo.Name = "rbtVeiculo";
            this.rbtVeiculo.Size = new System.Drawing.Size(60, 17);
            this.rbtVeiculo.TabIndex = 21;
            this.rbtVeiculo.TabStop = true;
            this.rbtVeiculo.Text = "Veiculo";
            this.rbtVeiculo.UseVisualStyleBackColor = true;
            this.rbtVeiculo.Visible = false;
            this.rbtVeiculo.CheckedChanged += new System.EventHandler(this.rbtVeiculo_CheckedChanged);
            // 
            // LocalizarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 733);
            this.Controls.Add(this.rbtVeiculo);
            this.Controls.Add(this.grbVeiculos);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "LocalizarVeiculo";
            this.Text = "LocalizarVeiculo";
            this.Load += new System.EventHandler(this.LocalizarVeiculo_Load);
            this.grbPesquisa.ResumeLayout(false);
            this.grbRenavam.ResumeLayout(false);
            this.grbRenavam.PerformLayout();
            this.grbPlaca.ResumeLayout(false);
            this.grbPlaca.PerformLayout();
            this.grbModel.ResumeLayout(false);
            this.grbModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.grbVeiculos.ResumeLayout(false);
            this.grbVeiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.GroupBox grbModel;
        private System.Windows.Forms.GroupBox grbRenavam;
        private System.Windows.Forms.TextBox txtPesqRenavam;
        private System.Windows.Forms.GroupBox grbPlaca;
        private System.Windows.Forms.TextBox txtPesqPlaca;
        private System.Windows.Forms.TextBox txtPesqModel;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.GroupBox grbVeiculos;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblAnom;
        private System.Windows.Forms.Label lblAnof;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox mskChassi;
        private System.Windows.Forms.MaskedTextBox mskRenavam;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbAnoM;
        private System.Windows.Forms.ComboBox cmbAnoF;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.ComboBox cmbPortas;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.RadioButton rbtVeiculo;
    }
}