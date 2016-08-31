namespace PIM
{
    partial class Aluguel
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
            this.btnDevolução = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.BtnSairAluguel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevolução);
            this.groupBox1.Controls.Add(this.btnDev);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnDevolução
            // 
            this.btnDevolução.Location = new System.Drawing.Point(33, 293);
            this.btnDevolução.Name = "btnDevolução";
            this.btnDevolução.Size = new System.Drawing.Size(124, 92);
            this.btnDevolução.TabIndex = 2;
            this.btnDevolução.Text = "Devolução";
            this.btnDevolução.UseVisualStyleBackColor = true;
            this.btnDevolução.Click += new System.EventHandler(this.btnDevolução_Click);
            // 
            // btnDev
            // 
            this.btnDev.Location = new System.Drawing.Point(33, 31);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(124, 92);
            this.btnDev.TabIndex = 1;
            this.btnDev.Text = "Aluguel";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // BtnSairAluguel
            // 
            this.BtnSairAluguel.Location = new System.Drawing.Point(494, 391);
            this.BtnSairAluguel.Name = "BtnSairAluguel";
            this.BtnSairAluguel.Size = new System.Drawing.Size(124, 92);
            this.BtnSairAluguel.TabIndex = 4;
            this.BtnSairAluguel.Text = "Sair";
            this.BtnSairAluguel.UseVisualStyleBackColor = true;
            this.BtnSairAluguel.Click += new System.EventHandler(this.BtnSairAluguel_Click);
            // 
            // Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 495);
            this.Controls.Add(this.BtnSairAluguel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aluguel";
            this.Text = "Aluguel";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDevolução;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button BtnSairAluguel;
    }
}