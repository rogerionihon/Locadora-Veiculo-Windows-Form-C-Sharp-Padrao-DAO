namespace PIM
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnLocacao = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevolucao);
            this.groupBox1.Controls.Add(this.btnLocacao);
            this.groupBox1.Controls.Add(this.btnVeiculo);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Location = new System.Drawing.Point(36, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.White;
            this.btnDevolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucao.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucao.Image")));
            this.btnDevolucao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevolucao.Location = new System.Drawing.Point(62, 431);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(124, 92);
            this.btnDevolucao.TabIndex = 3;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevolucao.UseVisualStyleBackColor = false;
            // 
            // btnLocacao
            // 
            this.btnLocacao.BackColor = System.Drawing.Color.White;
            this.btnLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocacao.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocacao.Image = ((System.Drawing.Image)(resources.GetObject("btnLocacao.Image")));
            this.btnLocacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocacao.Location = new System.Drawing.Point(62, 293);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Size = new System.Drawing.Size(124, 92);
            this.btnLocacao.TabIndex = 2;
            this.btnLocacao.Text = "Locação";
            this.btnLocacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocacao.UseVisualStyleBackColor = false;
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.BackColor = System.Drawing.Color.White;
            this.btnVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeiculo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculo.Image")));
            this.btnVeiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeiculo.Location = new System.Drawing.Point(62, 157);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(124, 92);
            this.btnVeiculo.TabIndex = 1;
            this.btnVeiculo.Text = "Veiculos";
            this.btnVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeiculo.UseVisualStyleBackColor = false;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(62, 19);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(124, 92);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(888, 505);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 92);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnLocacao;
        private System.Windows.Forms.Button btnSair;
    }
}