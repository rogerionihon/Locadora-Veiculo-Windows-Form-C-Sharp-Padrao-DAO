namespace PIM
{
    partial class RelatorioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPessoaJ = new System.Windows.Forms.Button();
            this.btnPessoaF = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnPessoaJ);
            this.groupBox1.Controls.Add(this.btnPessoaF);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPessoaJ
            // 
            this.btnPessoaJ.BackColor = System.Drawing.Color.White;
            this.btnPessoaJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoaJ.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaJ.Image = ((System.Drawing.Image)(resources.GetObject("btnPessoaJ.Image")));
            this.btnPessoaJ.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPessoaJ.Location = new System.Drawing.Point(33, 379);
            this.btnPessoaJ.Name = "btnPessoaJ";
            this.btnPessoaJ.Size = new System.Drawing.Size(124, 92);
            this.btnPessoaJ.TabIndex = 1;
            this.btnPessoaJ.Text = "Pessoa Juridica";
            this.btnPessoaJ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPessoaJ.UseVisualStyleBackColor = false;
            this.btnPessoaJ.Click += new System.EventHandler(this.btnPessoaJ_Click);
            // 
            // btnPessoaF
            // 
            this.btnPessoaF.BackColor = System.Drawing.Color.White;
            this.btnPessoaF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoaF.Font = new System.Drawing.Font("Arial Black", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoaF.Image = ((System.Drawing.Image)(resources.GetObject("btnPessoaF.Image")));
            this.btnPessoaF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPessoaF.Location = new System.Drawing.Point(33, 31);
            this.btnPessoaF.Name = "btnPessoaF";
            this.btnPessoaF.Size = new System.Drawing.Size(124, 92);
            this.btnPessoaF.TabIndex = 0;
            this.btnPessoaF.Text = "Pessoa Física";
            this.btnPessoaF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPessoaF.UseVisualStyleBackColor = false;
            this.btnPessoaF.Click += new System.EventHandler(this.btnPessoaF_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(574, 438);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 92);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioCliente";
            this.Text = "Relatório de Clientes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPessoaJ;
        private System.Windows.Forms.Button btnPessoaF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}