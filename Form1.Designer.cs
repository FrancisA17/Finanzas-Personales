namespace prjFinanzasPersonales
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.lblUserInfo = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.utilitariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeEgresosToolStripMenuItem,
            this.tiposDeIngresosToolStripMenuItem,
            this.tiposDePagosToolStripMenuItem,
            this.egresosToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // tiposDeEgresosToolStripMenuItem
            // 
            this.tiposDeEgresosToolStripMenuItem.Name = "tiposDeEgresosToolStripMenuItem";
            this.tiposDeEgresosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiposDeEgresosToolStripMenuItem.Text = "Tipos de Egresos";
            this.tiposDeEgresosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeEgresosToolStripMenuItem_Click);
            // 
            // tiposDeIngresosToolStripMenuItem
            // 
            this.tiposDeIngresosToolStripMenuItem.Name = "tiposDeIngresosToolStripMenuItem";
            this.tiposDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiposDeIngresosToolStripMenuItem.Text = "Tipos de Ingresos";
            this.tiposDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeIngresosToolStripMenuItem_Click);
            // 
            // tiposDePagosToolStripMenuItem
            // 
            this.tiposDePagosToolStripMenuItem.Name = "tiposDePagosToolStripMenuItem";
            this.tiposDePagosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tiposDePagosToolStripMenuItem.Text = "Tipos de Pagos";
            this.tiposDePagosToolStripMenuItem.Click += new System.EventHandler(this.tiposDePagosToolStripMenuItem_Click);
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.egresosToolStripMenuItem.Text = "Egresos";
            this.egresosToolStripMenuItem.Click += new System.EventHandler(this.egresosToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.Image = global::prjFinanzasPersonales.Properties.Resources.back;
            this.lnkLogOut.ImageSize = 32;
            this.lnkLogOut.Location = new System.Drawing.Point(675, 10);
            this.lnkLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(45, 37);
            this.lnkLogOut.TabIndex = 0;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(18, 378);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(81, 19);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Login with: ?";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 413);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroLabel lblUserInfo;
    }
}

