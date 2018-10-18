namespace AdventureWorks___Departamentos
{
    partial class frmEliminarDepartamento
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
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblMensajeExitoso = new System.Windows.Forms.Label();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEncabezadoEliminar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(86, 88);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEliminar.TabIndex = 0;
            this.lblNombreEliminar.Text = "Nombre";
            // 
            // lblMensajeExitoso
            // 
            this.lblMensajeExitoso.AutoSize = true;
            this.lblMensajeExitoso.Location = new System.Drawing.Point(152, 134);
            this.lblMensajeExitoso.Name = "lblMensajeExitoso";
            this.lblMensajeExitoso.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeExitoso.TabIndex = 1;
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(137, 85);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(131, 20);
            this.txtNombreEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(126, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEncabezadoEliminar
            // 
            this.lblEncabezadoEliminar.AutoSize = true;
            this.lblEncabezadoEliminar.Location = new System.Drawing.Point(123, 38);
            this.lblEncabezadoEliminar.Name = "lblEncabezadoEliminar";
            this.lblEncabezadoEliminar.Size = new System.Drawing.Size(85, 13);
            this.lblEncabezadoEliminar.TabIndex = 4;
            this.lblEncabezadoEliminar.Text = "Eliminar Registro";
            // 
            // frmEliminarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 238);
            this.Controls.Add(this.lblEncabezadoEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.lblMensajeExitoso);
            this.Controls.Add(this.lblNombreEliminar);
            this.Name = "frmEliminarDepartamento";
            this.Text = "frmEliminarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblMensajeExitoso;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEncabezadoEliminar;
    }
}