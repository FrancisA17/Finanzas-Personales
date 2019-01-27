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
    public partial class FrmUsuarios : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = null;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdUsuarios frm = new FrmEdUsuarios();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
                con.Open();
                string sql = "select u.UsuarioID, u.Nombre, u.Cedula, u.LimiteEgreso, u.TipoPersonaID, u.FechaCorte, u.Estado, u.NombreUsuario, u.Clave from Usuarios u INNER JOIN TipoPersona t ON u.TipoPersonaID = t.TipoPersonaID";
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
                FrmEdUsuarios frm = new FrmEdUsuarios();
                frm.id = row.Cells[0].Value.ToString();
                frm.nombre = row.Cells[1].Value.ToString();
                frm.cedula = row.Cells[2].Value.ToString();
                frm.limiteegreso = Convert.ToDouble(row.Cells[3].Value);
                frm.tipopersona = (int)(row.Cells[4].Value);
                frm.fechacorte = row.Cells[5].Value.ToString();
                frm.estado = (bool)(row.Cells[6].Value);
                frm.nombreusuario = row.Cells[7].Value.ToString();
                frm.clave = row.Cells[8].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar registro" + ex.Message);
            }
        }



        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        
    }
}
