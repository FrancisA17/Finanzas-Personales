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
    public partial class FrmEgresos : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        public FrmEgresos()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdEgresos frm = new FrmEdEgresos();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void FrmEgresos_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
                con.Open();
                string sql = "select * from Egresos";
                if (cbxCriterio.Text.Length > 0)
                {
                    sql += " where " + cbxCriterio.Text + " like '%" + txtBuscar.Text + "%'";
                    sql += " order by " + cbxCriterio.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
                dgvResultados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);

            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvResultados.SelectedRows[0];
                FrmEdEgresos frm = new FrmEdEgresos();
                frm.id = row.Cells[0].Value.ToString();
                frm.tipoegreso = (int)(row.Cells[1].Value);
                frm.tipopago = (int)(row.Cells[2].Value);
                frm.descripcion = row.Cells[3].Value.ToString();
                frm.estado = (bool)(row.Cells[4].Value);
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar registro" + ex.Message);
            }
        }

        

        private void FrmEgresos_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        
    }
}
