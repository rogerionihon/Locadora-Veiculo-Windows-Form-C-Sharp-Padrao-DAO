namespace PIM
{
    partial class LocalizarCliente
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
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.rbtPessoaj = new System.Windows.Forms.RadioButton();
            this.rbtPessoaf = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.rbtPessoaj);
            this.gbClientes.Controls.Add(this.rbtPessoaf);
            this.gbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(326, 66);
            this.gbClientes.TabIndex = 0;
            this.gbClientes.TabStop = false;
            // 
            // rbtPessoaj
            // 
            this.rbtPessoaj.AutoSize = true;
            this.rbtPessoaj.Location = new System.Drawing.Point(181, 24);
            this.rbtPessoaj.Name = "rbtPessoaj";
            this.rbtPessoaj.Size = new System.Drawing.Size(127, 22);
            this.rbtPessoaj.TabIndex = 1;
            this.rbtPessoaj.Text = "Pessoa juridica";
            this.rbtPessoaj.UseVisualStyleBackColor = true;
            this.rbtPessoaj.CheckedChanged += new System.EventHandler(this.rbtPessoaj_CheckedChanged);
            // 
            // rbtPessoaf
            // 
            this.rbtPessoaf.AutoSize = true;
            this.rbtPessoaf.Checked = true;
            this.rbtPessoaf.Location = new System.Drawing.Point(19, 24);
            this.rbtPessoaf.Name = "rbtPessoaf";
            this.rbtPessoaf.Size = new System.Drawing.Size(115, 22);
            this.rbtPessoaf.TabIndex = 0;
            this.rbtPessoaf.TabStop = true;
            this.rbtPessoaf.Text = "Pessoa fisica";
            this.rbtPessoaf.UseVisualStyleBackColor = true;
            this.rbtPessoaf.CheckedChanged += new System.EventHandler(this.rbtPessoaf_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // LocalizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbClientes);
            this.Name = "LocalizarCliente";
            this.Text = "LocalizarClienteFisico";
            this.Load += new System.EventHandler(this.LocalizarCliente_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.RadioButton rbtPessoaj;
        private System.Windows.Forms.RadioButton rbtPessoaf;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}