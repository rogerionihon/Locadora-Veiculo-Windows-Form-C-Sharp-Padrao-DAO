namespace PIM
{
    partial class CadastroFuncionario
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
            this.BtnCancelaFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelaFuncionario
            // 
            this.BtnCancelaFuncionario.Location = new System.Drawing.Point(548, 411);
            this.BtnCancelaFuncionario.Name = "BtnCancelaFuncionario";
            this.BtnCancelaFuncionario.Size = new System.Drawing.Size(124, 92);
            this.BtnCancelaFuncionario.TabIndex = 4;
            this.BtnCancelaFuncionario.Text = "Cancelar";
            this.BtnCancelaFuncionario.UseVisualStyleBackColor = true;
            this.BtnCancelaFuncionario.Click += new System.EventHandler(this.BtnCancelaFuncionario_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 524);
            this.Controls.Add(this.BtnCancelaFuncionario);
            this.Name = "CadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaFuncionario;
    }
}