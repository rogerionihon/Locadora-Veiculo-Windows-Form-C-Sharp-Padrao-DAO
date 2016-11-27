namespace PIM
{
    partial class RelatorioLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioLocacao));
            this.grbLocacao = new System.Windows.Forms.GroupBox();
            this.btnLocPesJur = new System.Windows.Forms.Button();
            this.btnLocPesFis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLocSair = new System.Windows.Forms.Button();
            this.grbLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLocacao
            // 
            this.grbLocacao.BackColor = System.Drawing.Color.Transparent;
            this.grbLocacao.Controls.Add(this.btnLocPesJur);
            this.grbLocacao.Controls.Add(this.btnLocPesFis);
            this.grbLocacao.Location = new System.Drawing.Point(23, 23);
            this.grbLocacao.Name = "grbLocacao";
            this.grbLocacao.Size = new System.Drawing.Size(194, 493);
            this.grbLocacao.TabIndex = 0;
            this.grbLocacao.TabStop = false;
            // 
            // btnLocPesJur
            // 
            this.btnLocPesJur.BackColor = System.Drawing.Color.White;
            this.btnLocPesJur.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPesJur.Image = ((System.Drawing.Image)(resources.GetObject("btnLocPesJur.Image")));
            this.btnLocPesJur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocPesJur.Location = new System.Drawing.Point(33, 372);
            this.btnLocPesJur.Name = "btnLocPesJur";
            this.btnLocPesJur.Size = new System.Drawing.Size(124, 92);
            this.btnLocPesJur.TabIndex = 1;
            this.btnLocPesJur.Text = "Pessoa Juridica";
            this.btnLocPesJur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocPesJur.UseVisualStyleBackColor = false;
            this.btnLocPesJur.Click += new System.EventHandler(this.btnLocPesJur_Click);
            // 
            // btnLocPesFis
            // 
            this.btnLocPesFis.BackColor = System.Drawing.Color.White;
            this.btnLocPesFis.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocPesFis.Image = ((System.Drawing.Image)(resources.GetObject("btnLocPesFis.Image")));
            this.btnLocPesFis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocPesFis.Location = new System.Drawing.Point(33, 31);
            this.btnLocPesFis.Name = "btnLocPesFis";
            this.btnLocPesFis.Size = new System.Drawing.Size(124, 92);
            this.btnLocPesFis.TabIndex = 0;
            this.btnLocPesFis.Text = "Pessoa Física";
            this.btnLocPesFis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocPesFis.UseVisualStyleBackColor = false;
            this.btnLocPesFis.Click += new System.EventHandler(this.btnLocPesFis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PIM.Properties.Resources.logo_Correto;
            this.pictureBox1.Location = new System.Drawing.Point(298, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLocSair
            // 
            this.btnLocSair.BackColor = System.Drawing.Color.White;
            this.btnLocSair.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocSair.Image = ((System.Drawing.Image)(resources.GetObject("btnLocSair.Image")));
            this.btnLocSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocSair.Location = new System.Drawing.Point(574, 438);
            this.btnLocSair.Name = "btnLocSair";
            this.btnLocSair.Size = new System.Drawing.Size(124, 92);
            this.btnLocSair.TabIndex = 2;
            this.btnLocSair.Text = "Sair";
            this.btnLocSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocSair.UseVisualStyleBackColor = false;
            this.btnLocSair.Click += new System.EventHandler(this.btnLocSair_Click);
            // 
            // RelatorioLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIM.Properties.Resources.Azul02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLocSair);
            this.Controls.Add(this.grbLocacao);
            this.MaximizeBox = false;
            this.Name = "RelatorioLocacao";
            this.Text = "Relatorio de Locação";
            this.grbLocacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLocacao;
        private System.Windows.Forms.Button btnLocPesJur;
        private System.Windows.Forms.Button btnLocPesFis;
        private System.Windows.Forms.Button btnLocSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}