namespace PIM
{
    partial class Cadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAutomovel = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.BtnSairCadastro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFuncionario);
            this.groupBox1.Controls.Add(this.BtnCliente);
            this.groupBox1.Controls.Add(this.btnAutomovel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAutomovel
            // 
            this.btnAutomovel.Location = new System.Drawing.Point(62, 224);
            this.btnAutomovel.Name = "btnAutomovel";
            this.btnAutomovel.Size = new System.Drawing.Size(124, 92);
            this.btnAutomovel.TabIndex = 1;
            this.btnAutomovel.Text = "Automovel";
            this.btnAutomovel.UseVisualStyleBackColor = true;
            this.btnAutomovel.Click += new System.EventHandler(this.btnAutomovel_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(62, 19);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(124, 92);
            this.BtnCliente.TabIndex = 2;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(62, 428);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(124, 92);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // BtnSairCadastro
            // 
            this.BtnSairCadastro.Location = new System.Drawing.Point(888, 505);
            this.BtnSairCadastro.Name = "BtnSairCadastro";
            this.BtnSairCadastro.Size = new System.Drawing.Size(124, 92);
            this.BtnSairCadastro.TabIndex = 4;
            this.BtnSairCadastro.Text = "Sair";
            this.BtnSairCadastro.UseVisualStyleBackColor = true;
            this.BtnSairCadastro.Click += new System.EventHandler(this.BtnSairCadastro_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.BtnSairCadastro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button btnAutomovel;
        private System.Windows.Forms.Button BtnSairCadastro;
    }
}