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
    public partial class frmCrearDepartamentos : Form
    {
        public frmCrearDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server = (local)\chrisfiallos;
                database = AdventureWorks2014; Integrated Security = true;");

            SqlCommand cmd = new SqlCommand("SP_HumanResources_Department_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreDepartamento.Text;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = txtGroupNameDepartamentos.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpCrearDepartamento.Value;

                    cmd.ExecuteNonQuery();

                    lblEstadoInsercion.Text = "El registro se insrto correctamente!";
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
