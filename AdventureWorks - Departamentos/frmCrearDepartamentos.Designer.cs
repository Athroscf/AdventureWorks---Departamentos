namespace AdventureWorks___Departamentos
{
    partial class frmCrearDepartamentos
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
            this.lblNombreDepartamento = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lblGroupNameDepartamentos = new System.Windows.Forms.Label();
            this.txtGroupNameDepartamentos = new System.Windows.Forms.TextBox();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.dtpCrearDepartamento = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEstadoInsercion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreDepartamento
            // 
            this.lblNombreDepartamento.AutoSize = true;
            this.lblNombreDepartamento.Location = new System.Drawing.Point(50, 38);
            this.lblNombreDepartamento.Name = "lblNombreDepartamento";
            this.lblNombreDepartamento.Size = new System.Drawing.Size(44, 13);
            this.lblNombreDepartamento.TabIndex = 0;
            this.lblNombreDepartamento.Text = "Nombre";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(146, 31);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(200, 20);
            this.txtNombreDepartamento.TabIndex = 1;
            // 
            // lblGroupNameDepartamentos
            // 
            this.lblGroupNameDepartamentos.AutoSize = true;
            this.lblGroupNameDepartamentos.Location = new System.Drawing.Point(50, 82);
            this.lblGroupNameDepartamentos.Name = "lblGroupNameDepartamentos";
            this.lblGroupNameDepartamentos.Size = new System.Drawing.Size(67, 13);
            this.lblGroupNameDepartamentos.TabIndex = 2;
            this.lblGroupNameDepartamentos.Text = "Group Name";
            // 
            // txtGroupNameDepartamentos
            // 
            this.txtGroupNameDepartamentos.Location = new System.Drawing.Point(146, 79);
            this.txtGroupNameDepartamentos.Name = "txtGroupNameDepartamentos";
            this.txtGroupNameDepartamentos.Size = new System.Drawing.Size(200, 20);
            this.txtGroupNameDepartamentos.TabIndex = 3;
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(136, 226);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCrearDepartamento.TabIndex = 4;
            this.btnCrearDepartamento.Text = "Crear";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // dtpCrearDepartamento
            // 
            this.dtpCrearDepartamento.Location = new System.Drawing.Point(146, 124);
            this.dtpCrearDepartamento.Name = "dtpCrearDepartamento";
            this.dtpCrearDepartamento.Size = new System.Drawing.Size(200, 20);
            this.dtpCrearDepartamento.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(50, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Fecha";
            // 
            // lblEstadoInsercion
            // 
            this.lblEstadoInsercion.AutoSize = true;
            this.lblEstadoInsercion.Location = new System.Drawing.Point(121, 184);
            this.lblEstadoInsercion.Name = "lblEstadoInsercion";
            this.lblEstadoInsercion.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoInsercion.TabIndex = 7;
            // 
            // frmCrearDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 277);
            this.Controls.Add(this.lblEstadoInsercion);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpCrearDepartamento);
            this.Controls.Add(this.btnCrearDepartamento);
            this.Controls.Add(this.txtGroupNameDepartamentos);
            this.Controls.Add(this.lblGroupNameDepartamentos);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.lblNombreDepartamento);
            this.Name = "frmCrearDepartamentos";
            this.Text = "frmCrearDepartamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Label lblGroupNameDepartamentos;
        private System.Windows.Forms.TextBox txtGroupNameDepartamentos;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.DateTimePicker dtpCrearDepartamento;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEstadoInsercion;
    }
}