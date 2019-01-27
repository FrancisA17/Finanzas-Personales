using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjFinanzasPersonales
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        static FrmLogin _instance;

        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmLogin();
                return _instance;
            }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Favor ingrese su Usuario.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
            try
            {
                using (BDFinanzasPersonalesEntities db = new BDFinanzasPersonalesEntities())
                {
                    var query = from u in db.Usuarios
                                where u.NombreUsuario == txtUsuario.Text && u.Clave == txtPassword.Text
                                select u;
                    if(query.SingleOrDefault() != null)
                    {
                        this.Hide();
                        FrmMenu frm = new FrmMenu(string.Format("Logeado con: {0}", txtUsuario.Text));
                        frm.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Datos incorrectos", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
