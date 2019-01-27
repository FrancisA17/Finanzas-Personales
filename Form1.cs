using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinanzasPersonales
{
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        bool _logOut;
        public FrmMenu(string userInfo)
        {
            InitializeComponent();
            lblUserInfo.Text = userInfo;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tiposDeEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposEgresos frm = new FrmTiposEgresos();
            frm.ShowDialog();
        }

        private void tiposDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposIngresos frm = new FrmTiposIngresos();
            frm.ShowDialog();
        }

        private void tiposDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposPagos frm = new FrmTiposPagos();
            frm.ShowDialog();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEgresos frm = new FrmEgresos();
            frm.ShowDialog();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos frm = new FrmIngresos();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            _logOut = true;
            this.Close();
            FrmLogin.Instance.Show();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menu form close
            if (!_logOut)
                Application.Exit();
        }
    }
}
