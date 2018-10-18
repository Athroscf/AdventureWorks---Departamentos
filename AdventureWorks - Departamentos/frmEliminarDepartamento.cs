using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdventureWorks___Departamentos
{
    public partial class frmEliminarDepartamento : Form
    {
        public frmEliminarDepartamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server = (local)\chrisfiallos;
                database = AdventureWorks2014; Integrated Security = true;");

            SqlCommand cmd = new SqlCommand("SP_HumanResources_Department_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreEliminar.Text;

                    cmd.ExecuteNonQuery();

                    lblMensajeExitoso.Text = "El registro fue eliminado exitosamente!";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la Excepcion");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
