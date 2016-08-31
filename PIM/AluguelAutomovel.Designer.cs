namespace PIM
{
    partial class AluguelAutomovel
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
            this.BtnCancelaAluguelAutomovel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelaAluguelAutomovel
            // 
            this.BtnCancelaAluguelAutomovel.Location = new System.Drawing.Point(492, 407);
            this.BtnCancelaAluguelAutomovel.Name = "BtnCancelaAluguelAutomovel";
            this.BtnCancelaAluguelAutomovel.Size = new System.Drawing.Size(124, 92);
            this.BtnCancelaAluguelAutomovel.TabIndex = 5;
            this.BtnCancelaAluguelAutomovel.Text = "Cancelar";
            this.BtnCancelaAluguelAutomovel.UseVisualStyleBackColor = true;
            this.BtnCancelaAluguelAutomovel.Click += new System.EventHandler(this.BtnCancelaAluguelAutomovel_Click);
            // 
            // AluguelAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 511);
            this.Controls.Add(this.BtnCancelaAluguelAutomovel);
            this.Name = "AluguelAutomovel";
            this.Text = "AluguelAutomovel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaAluguelAutomovel;
    }
}