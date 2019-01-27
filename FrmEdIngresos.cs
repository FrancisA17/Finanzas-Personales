using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinanzasPersonales
{
    public partial class FrmEdIngresos : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con { get; set; }
        public string id { get; set; }
        public int tipoingreso { get; set; }
        public string descripcion { get; set; }
        public string institucion { get; set; }
        public bool estado { get; set; }
        public string modo { get; set; }
        public FrmEdIngresos()
        {
            InitializeComponent();
        }

        private void FrmEdIngresos_Load(object sender, EventArgs e)
        {
            llenarTipoIngreso();
            try
            {
                txtId.Text = id;
                CbxTipoIngreso.SelectedIndex = tipoingreso - 1;
                txtDescripcion.Text = descripcion;
                txtInstitucion.Text = institucion;
                CbxEstado.SelectedIndex = Convert.ToInt32(estado);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "insert into Ingresos (TipoIngresoID, Descripcion, Institucion, Estado) values ('";
                    sql += ((int)(CbxTipoIngreso.SelectedIndex) + 1) + "', '" + txtDescripcion.Text + "','";
                    sql += txtInstitucion.Text + "', '" + CbxEstado.SelectedIndex + "')";
                }
                else
                {
                    sql = "update Ingresos set ";
                    sql += "TipoIngresoID = '" + ((int)(CbxTipoIngreso.SelectedIndex) + 1) + "',";
                    sql += "Descripcion = '" + txtDescripcion.Text + "',";
                    sql += "Institucion = '" + txtInstitucion.Text + "',";
                    sql += "estado = '" + CbxEstado.SelectedIndex + "'";
                    sql += " where IngresoID = '" + txtId.Text + "'";

                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Ingresos ";
                sql += " where IngresoID = '" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el registro");
            }
        }

        private void llenarTipoIngreso()
        {
            con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
            con.Open();
            string sql = "select * from TipoIngreso";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbxTipoIngreso.Items.Add(dt.Rows[i]["Descripcion"]);
            }


        }
    }
}
