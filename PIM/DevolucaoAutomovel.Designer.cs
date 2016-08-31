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
            this.BtnCancelaDevolucaoAutomovel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelaDevolucaoAutomovel
            // 
            this.BtnCancelaDevolucaoAutomovel.Location = new System.Drawing.Point(542, 437);
            this.BtnCancelaDevolucaoAutomovel.Name = "BtnCancelaDevolucaoAutomovel";
            this.BtnCancelaDevolucaoAutomovel.Size = new System.Drawing.Size(124, 92);
            this.BtnCancelaDevolucaoAutomovel.TabIndex = 6;
            this.BtnCancelaDevolucaoAutomovel.Text = "Cancelar";
            this.BtnCancelaDevolucaoAutomovel.UseVisualStyleBackColor = true;
            this.BtnCancelaDevolucaoAutomovel.Click += new System.EventHandler(this.BtnCancelaDevolucaoAutomovel_Click);
            // 
            // DevolucaoAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 541);
            this.Controls.Add(this.BtnCancelaDevolucaoAutomovel);
            this.Name = "DevolucaoAutomovel";
            this.Text = "Devolução de Automovel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaDevolucaoAutomovel;
    }
}