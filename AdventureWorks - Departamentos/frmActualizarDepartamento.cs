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
    public partial class frmActualizarDepartamento : Form
    {
        public frmActualizarDepartamento()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server = (local)\chrisfiallos;
                database = AdventureWorks2014; Integrated Security = true;");

            SqlCommand cmd = new SqlCommand("SP_HumanResources_Department_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtNombreUpdate.Text;
                    cmd.Parameters.Add("@newName", SqlDbType.NVarChar).Value = txtNewName.Text;
                    cmd.Parameters.Add("@GroupName", SqlDbType.NVarChar).Value = txtNewGroupName.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpNewDate.Value;

                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Registro actualizado correctamente!";
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
