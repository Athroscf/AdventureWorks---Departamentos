namespace AdventureWorks___Departamentos
{
    partial class frmActualizarDepartamento
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
            this.lblNombreUpdate = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewGroupName = new System.Windows.Forms.Label();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.txtNombreUpdate = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewGroupName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreUpdate
            // 
            this.lblNombreUpdate.AutoSize = true;
            this.lblNombreUpdate.Location = new System.Drawing.Point(25, 47);
            this.lblNombreUpdate.Name = "lblNombreUpdate";
            this.lblNombreUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblNombreUpdate.TabIndex = 0;
            this.lblNombreUpdate.Text = "Nombre";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(25, 137);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(79, 13);
            this.lblNewName.TabIndex = 1;
            this.lblNewName.Text = "Nuevo Nombre";
            // 
            // lblNewGroupName
            // 
            this.lblNewGroupName.AutoSize = true;
            this.lblNewGroupName.Location = new System.Drawing.Point(25, 182);
            this.lblNewGroupName.Name = "lblNewGroupName";
            this.lblNewGroupName.Size = new System.Drawing.Size(99, 13);
            this.lblNewGroupName.TabIndex = 2;
            this.lblNewGroupName.Text = "Nuevo GroupName";
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(25, 220);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(72, 13);
            this.lblNewDate.TabIndex = 3;
            this.lblNewDate.Text = "Nueva Fecha";
            // 
            // txtNombreUpdate
            // 
            this.txtNombreUpdate.Location = new System.Drawing.Point(132, 44);
            this.txtNombreUpdate.Name = "txtNombreUpdate";
            this.txtNombreUpdate.Size = new System.Drawing.Size(122, 20);
            this.txtNombreUpdate.TabIndex = 4;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(132, 134);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(122, 20);
            this.txtNewName.TabIndex = 5;
            // 
            // txtNewGroupName
            // 
            this.txtNewGroupName.Location = new System.Drawing.Point(132, 179);
            this.txtNewGroupName.Name = "txtNewGroupName";
            this.txtNewGroupName.Size = new System.Drawing.Size(122, 20);
            this.txtNewGroupName.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(162, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Location = new System.Drawing.Point(132, 220);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(200, 20);
            this.dtpNewDate.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(218, 89);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "label1";
            // 
            // frmActualizarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 353);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewGroupName);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNombreUpdate);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.lblNewGroupName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblNombreUpdate);
            this.Name = "frmActualizarDepartamento";
            this.Text = "frmActualizarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUpdate;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewGroupName;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.TextBox txtNombreUpdate;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewGroupName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label lblMessage;
    }
}