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
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelaDevolucaoAutomovel
            // 
            this.BtnCancelaDevolucaoAutomovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelaDevolucaoAutomovel.Location = new System.Drawing.Point(795, 432);
            this.BtnCancelaDevolucaoAutomovel.Name = "BtnCancelaDevolucaoAutomovel";
            this.BtnCancelaDevolucaoAutomovel.Size = new System.Drawing.Size(124, 92);
            this.BtnCancelaDevolucaoAutomovel.TabIndex = 6;
            this.BtnCancelaDevolucaoAutomovel.Text = "Cancelar";
            this.BtnCancelaDevolucaoAutomovel.UseVisualStyleBackColor = true;
            this.BtnCancelaDevolucaoAutomovel.Click += new System.EventHandler(this.BtnCancelaDevolucaoAutomovel_Click);
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(37, 59);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(847, 246);
            this.gridView.TabIndex = 7;
            // 
            // DevolucaoAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 716);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.BtnCancelaDevolucaoAutomovel);
            this.Name = "DevolucaoAutomovel";
            this.Text = "Devolução de Automovel";
            this.Load += new System.EventHandler(this.DevolucaoAutomovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelaDevolucaoAutomovel;
        private System.Windows.Forms.DataGridView gridView;
    }
}