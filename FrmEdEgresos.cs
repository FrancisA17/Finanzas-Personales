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
    public partial class FrmEdEgresos : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con { get; set; }
        public string id { get; set; }
        public int tipoegreso { get; set; }
        public int tipopago { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public string modo { get; set; }
        public FrmEdEgresos()
        {
            InitializeComponent();
        }

        private void FrmEdEgresos_Load(object sender, EventArgs e)
        {
            llenarTipoEgreso();
            llenarTipoPago();
            try
            {
                txtId.Text = id;
                CbxTipoEgreso.SelectedIndex = tipoegreso-1;
                CbxTipoPago.SelectedIndex = tipopago-1;
                txtDescripcion.Text = descripcion;
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
                    sql = "insert into Egresos (TipoEgresoID, TipoPagoxDefecto, Descripcion, Estado) values ('";
                    sql += ((int)(CbxTipoEgreso.SelectedIndex) + 1) + "', '" + ((int)(CbxTipoPago.SelectedIndex) + 1) + "','";
                    sql += txtDescripcion.Text + "', '" + CbxEstado.SelectedIndex + "')";
                }
                else
                {
                    sql = "update Egresos set ";
                    sql += "TipoEgresoID = '" + ((int)(CbxTipoEgreso.SelectedIndex)+1) + "',";
                    sql += "TipoPagoxDefecto = '" + ((int)(CbxTipoPago.SelectedIndex)+1) + "',";
                    sql += "Descripcion = '" + txtDescripcion.Text + "',";
                    sql += "estado = '" + CbxEstado.SelectedIndex + "'";
                    sql += " where EgresoID = '" + txtId.Text + "'";

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
                string sql = "delete Egresos ";
                sql += " where EgresoID = '" + txtId.Text + "'";
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

        private void llenarTipoEgreso()
        {
            con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
            con.Open();
            string sql = "select * from TipoEgreso";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbxTipoEgreso.Items.Add(dt.Rows[i]["Descripcion"]);
            }


        }

        private void llenarTipoPago()
        {
            con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
            con.Open();
            string sql = "select * from TipoPago";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbxTipoPago.Items.Add(dt.Rows[i]["Descripcion"]);
            }


        }


    }
}
