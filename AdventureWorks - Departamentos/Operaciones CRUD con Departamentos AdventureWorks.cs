using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorks___Departamentos
{
    public partial class frmMenuOperacionesCRUD : Form
    {
        public frmMenuOperacionesCRUD()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarDepartamentos newForm = new frmListarDepartamentos();
            newForm.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearDepartamentos newForm = new frmCrearDepartamentos();
            newForm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarDepartamento newForm = new frmActualizarDepartamento();
            newForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarDepartamento newForm = new frmEliminarDepartamento();
            newForm.Show();
        }
    }
}
