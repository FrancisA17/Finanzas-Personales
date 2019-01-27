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
    public partial class FrmEdUsuarios : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public double limiteegreso { get; set; }
        public int tipopersona { get; set; }
        public string fechacorte { get; set; }
        public bool estado { get; set; }
        public string modo { get; set; }
        public string nombreusuario { get; set; }
        public string clave { get; set; }
        public FrmEdUsuarios()
        {
            InitializeComponent();
        }

        private void FrmEdUsuarios_Load(object sender, EventArgs e)
        {
            llenarCombo();
            try
            {
                txtId.Text = id;
                txtNombre.Text = nombre;
                txtCedula.Text = cedula;
                txtLimiteEgreso.Text = limiteegreso.ToString();
                CbxTipoPersona.SelectedIndex = tipopersona - 1;
                txtFechaCorte.Text = fechacorte;
                CbxEstado.SelectedIndex = Convert.ToInt32(estado);
                txtUsuario.Text = nombreusuario;
                txtPassword.Text = clave;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if(!validaCedula(txtCedula.Text))
            {
                MessageBox.Show("Cédula incorrecta");
                txtCedula.Focus();
            }
            else
            {
                try
                {
                    string sql = "";
                    if (modo.Equals("C"))
                    {
                        sql = "insert into Usuarios (Nombre, Cedula, LimiteEgreso, TipoPersonaID, FechaCorte, Estado, NombreUsuario, Clave) values ('";
                        sql += txtNombre.Text + "', '" + txtCedula.Text + "','";
                        sql += Convert.ToDouble(txtLimiteEgreso.Text) + "', '" + ((int)(CbxTipoPersona.SelectedIndex) + 1) + "','";
                        sql += txtFechaCorte.Text + "', '" + CbxEstado.SelectedIndex + "', '" + txtUsuario.Text + "', '" + txtPassword.Text + "')";
                    }
                    else
                    {
                        sql = "update Usuarios set ";
                        sql += "Nombre = '" + txtNombre.Text + "',";
                        sql += "Cedula = '" + txtCedula.Text + "',";
                        sql += "LimiteEgreso = '" + Convert.ToDouble(txtLimiteEgreso.Text) + "',";
                        sql += "TipoPersonaID = '" + ((int)(CbxTipoPersona.SelectedIndex) + 1) + "',";
                        sql += "FechaCorte = '" + txtFechaCorte.Text + "',";
                        sql += "estado = '" + CbxEstado.SelectedIndex + "',";
                        sql += "NombreUsuario = '" + txtUsuario.Text + "',";
                        sql += "Clave = '" + txtPassword.Text + "'";
                        sql += " where UsuarioID = '" + txtId.Text + "'";

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
           
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Usuarios ";
                sql += " where UsuarioID = '" + txtId.Text + "'";
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

        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }
            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private void llenarCombo()
        {
            con = new SqlConnection("Data Source=Sordon-Alien;Initial Catalog=PersonalFinancesDB;Integrated Security=True");
            con.Open();
            string sql = "select * from TipoPersona";
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CbxTipoPersona.Items.Add(dt.Rows[i]["Descripcion"]);
            }
            
            
        }


    }
}
