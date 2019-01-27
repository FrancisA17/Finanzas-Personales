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
    public partial class FrmTiposPagos : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        public FrmTiposPagos()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdTiposPagos frm = new FrmEdTiposPagos();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void FrmTiposPagos_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
                con.Open();
                string sql = "select * from TipoPago";
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
                FrmEdTiposPagos frm = new FrmEdTiposPagos();
                frm.id = row.Cells[0].Value.ToString();
                frm.descripcion = row.Cells[1].Value.ToString();
                frm.estado = (bool)(row.Cells[2].Value);
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar registro" + ex.Message);
            }
        }

        private void FrmTiposEgresos_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void FrmTiposPagos_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void FrmTiposPagos_Activated_1(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        
    }
}
