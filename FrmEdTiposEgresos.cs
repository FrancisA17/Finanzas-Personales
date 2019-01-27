﻿using System;
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
    public partial class FrmEdTiposEgresos : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con { get; set; }
        public string id { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public string modo { get; set; }
        public FrmEdTiposEgresos()
        {
            InitializeComponent();
        }

        private void FrmEdTiposEgresos_Load(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = id;
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
                    sql = "insert into TipoEgreso (Descripcion, Estado) values ('";
                    sql += txtDescripcion.Text + "', '" + CbxEstado.SelectedIndex + "')";
                }
                else
                {
                    sql = "update TipoEgreso set ";
                    sql += "descripcion = '" + txtDescripcion.Text + "',";
                    sql += "estado = '" + CbxEstado.SelectedIndex + "'";
                    sql += " where TipoEgresoID = '" + txtId.Text + "'";

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
                string sql = "delete TipoEgreso ";
                sql += " where TipoEgresoID = '" + txtId.Text + "'";
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
    }
}
