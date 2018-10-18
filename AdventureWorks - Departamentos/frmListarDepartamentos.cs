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
    public partial class frmListarDepartamentos : Form
    {
        public frmListarDepartamentos()
        {
            InitializeComponent();
        }

        private void frmListarDepartamentos_Load(object sender, EventArgs e)
        {
            string conn = @"server = (local)\chrisfiallos;
                database = AdventureWorks2014; Integrated Security = true;";

            string sql = @"SELECT * FROM HumanResources.Department";

            SqlConnection sqlconn = new SqlConnection(conn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, sqlconn);

                DataSet ds = new DataSet();

                da.Fill(ds, "HumanResources.Department");

                DataTable dt = ds.Tables["HumanResources.Department"];

                DataView dv = new DataView(dt, "Name = GroupName", "Name", DataViewRowState.Unchanged);

                gvListaDepartamentos.DataSource = dv;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la Excepcion");
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}
