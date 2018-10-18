namespace AdventureWorks___Departamentos
{
    partial class frmMenuOperacionesCRUD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMenuPrincipal = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbxMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMenuPrincipal
            // 
            this.gbxMenuPrincipal.Controls.Add(this.btnEliminar);
            this.gbxMenuPrincipal.Controls.Add(this.btnActualizar);
            this.gbxMenuPrincipal.Controls.Add(this.btnCrear);
            this.gbxMenuPrincipal.Controls.Add(this.btnListar);
            this.gbxMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMenuPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbxMenuPrincipal.Name = "gbxMenuPrincipal";
            this.gbxMenuPrincipal.Size = new System.Drawing.Size(523, 285);
            this.gbxMenuPrincipal.TabIndex = 0;
            this.gbxMenuPrincipal.TabStop = false;
            this.gbxMenuPrincipal.Text = "Operaciones Disponibles para Departamentos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(280, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(222, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Departamentos";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(17, 175);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(242, 43);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar Departamentos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(280, 77);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(222, 43);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear Departamentos";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(17, 77);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(242, 43);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar Departamentos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmMenuOperacionesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 313);
            this.Controls.Add(this.gbxMenuPrincipal);
            this.Name = "frmMenuOperacionesCRUD";
            this.Text = "Operaciones CRUD con Departamentos AdventureWorks";
            this.gbxMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMenuPrincipal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnListar;
    }
}

