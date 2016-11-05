namespace PIM
{
    partial class LocalizarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSairLocalizacao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFuncionarios);
            this.groupBox1.Controls.Add(this.btnVeiculos);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionarios.Location = new System.Drawing.Point(62, 428);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(124, 92);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.White;
            this.btnVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeiculos.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeiculos.Location = new System.Drawing.Point(62, 225);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(124, 92);
            this.btnVeiculos.TabIndex = 1;
            this.btnVeiculos.Text = "Veiculos";
            this.btnVeiculos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(62, 19);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(124, 92);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSairLocalizacao
            // 
            this.btnSairLocalizacao.BackColor = System.Drawing.Color.White;
            this.btnSairLocalizacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairLocalizacao.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairLocalizacao.Image = ((System.Drawing.Image)(resources.GetObject("btnSairLocalizacao.Image")));
            this.btnSairLocalizacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSairLocalizacao.Location = new System.Drawing.Point(888, 505);
            this.btnSairLocalizacao.Name = "btnSairLocalizacao";
            this.btnSairLocalizacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSairLocalizacao.Size = new System.Drawing.Size(124, 92);
            this.btnSairLocalizacao.TabIndex = 1;
            this.btnSairLocalizacao.Text = "Sair";
            this.btnSairLocalizacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSairLocalizacao.UseVisualStyleBackColor = false;
            this.btnSairLocalizacao.Click += new System.EventHandler(this.btnSairLocalizacao_Click);
            // 
            // LocalizarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.btnSairLocalizacao);
            this.Controls.Add(this.groupBox1);
            this.Name = "LocalizarMenu";
            this.Text = "LocalizarMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSairLocalizacao;
    }
}