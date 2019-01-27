namespace prjFinanzasPersonales
{
    partial class FrmEdEgresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdEgresos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxEstado = new MetroFramework.Controls.MetroComboBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.CbxTipoPago = new MetroFramework.Controls.MetroComboBox();
            this.CbxTipoEgreso = new MetroFramework.Controls.MetroComboBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmdEliminar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbxEstado);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.CbxTipoPago);
            this.panel1.Controls.Add(this.CbxTipoEgreso);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(18, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 230);
            this.panel1.TabIndex = 13;
            // 
            // CbxEstado
            // 
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.ItemHeight = 23;
            this.CbxEstado.Location = new System.Drawing.Point(135, 178);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(121, 29);
            this.CbxEstado.TabIndex = 24;
            this.CbxEstado.UseSelectable = true;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(135, 142);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(121, 23);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbxTipoPago
            // 
            this.CbxTipoPago.FormattingEnabled = true;
            this.CbxTipoPago.ItemHeight = 23;
            this.CbxTipoPago.Location = new System.Drawing.Point(135, 104);
            this.CbxTipoPago.Name = "CbxTipoPago";
            this.CbxTipoPago.Size = new System.Drawing.Size(121, 29);
            this.CbxTipoPago.TabIndex = 22;
            this.CbxTipoPago.UseSelectable = true;
            // 
            // CbxTipoEgreso
            // 
            this.CbxTipoEgreso.FormattingEnabled = true;
            this.CbxTipoEgreso.ItemHeight = 23;
            this.CbxTipoEgreso.Location = new System.Drawing.Point(135, 63);
            this.CbxTipoEgreso.Name = "CbxTipoEgreso";
            this.CbxTipoEgreso.Size = new System.Drawing.Size(121, 29);
            this.CbxTipoEgreso.TabIndex = 16;
            this.CbxTipoEgreso.UseSelectable = true;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(135, 31);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 178);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Estado";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Descripción";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Tipo de Pago";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Tipo de Egreso";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "ID";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.BackgroundImage")));
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdEliminar.Location = new System.Drawing.Point(167, 308);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 67);
            this.cmdEliminar.TabIndex = 16;
            this.cmdEliminar.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(69, 308);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 67);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.UseSelectable = true;
            // 
            // FrmEdEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 392);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEdEgresos";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Edición de Egresos";
            this.Load += new System.EventHandler(this.FrmEdEgresos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CbxTipoEgreso;
        private MetroFramework.Controls.MetroComboBox CbxTipoPago;
        private MetroFramework.Controls.MetroComboBox CbxEstado;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroButton cmdEliminar;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}