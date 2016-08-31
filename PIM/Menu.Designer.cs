namespace PIM
{
    partial class frmMenu
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
            this.MnuBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnAluguel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.MnuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuBox
            // 
            this.MnuBox.Controls.Add(this.button5);
            this.MnuBox.Controls.Add(this.BtnAluguel);
            this.MnuBox.Controls.Add(this.button3);
            this.MnuBox.Controls.Add(this.button2);
            this.MnuBox.Controls.Add(this.btnCadastro);
            this.MnuBox.Location = new System.Drawing.Point(12, 12);
            this.MnuBox.Name = "MnuBox";
            this.MnuBox.Size = new System.Drawing.Size(142, 613);
            this.MnuBox.TabIndex = 0;
            this.MnuBox.TabStop = false;
            this.MnuBox.Text = "Menu";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 92);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnAluguel
            // 
            this.BtnAluguel.Location = new System.Drawing.Point(6, 117);
            this.BtnAluguel.Name = "BtnAluguel";
            this.BtnAluguel.Size = new System.Drawing.Size(124, 92);
            this.BtnAluguel.TabIndex = 3;
            this.BtnAluguel.Text = "Aluguel";
            this.BtnAluguel.UseVisualStyleBackColor = true;
            this.BtnAluguel.Click += new System.EventHandler(this.BtnAluguel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(6, 19);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(124, 92);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(1252, 497);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(158, 104);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 627);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.MnuBox);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MnuBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MnuBox;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnAluguel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastro;
    }
}

