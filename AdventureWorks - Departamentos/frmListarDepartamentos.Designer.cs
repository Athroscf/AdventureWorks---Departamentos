namespace AdventureWorks___Departamentos
{
    partial class frmListarDepartamentos
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
            this.gvListaDepartamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaDepartamentos
            // 
            this.gvListaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaDepartamentos.Location = new System.Drawing.Point(83, 12);
            this.gvListaDepartamentos.Name = "gvListaDepartamentos";
            this.gvListaDepartamentos.Size = new System.Drawing.Size(267, 306);
            this.gvListaDepartamentos.TabIndex = 0;
            // 
            // frmListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 330);
            this.Controls.Add(this.gvListaDepartamentos);
            this.Name = "frmListarDepartamentos";
            this.Text = "Listar Departamentos";
            this.Load += new System.EventHandler(this.frmListarDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaDepartamentos;
    }
}