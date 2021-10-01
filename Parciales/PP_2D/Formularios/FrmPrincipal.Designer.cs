
namespace Formularios
{
    partial class FrmPrincipal
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
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnCabinas = new MetroFramework.Controls.MetroTile();
            this.btnComputadoras = new MetroFramework.Controls.MetroTile();
            this.btnDirectorio = new MetroFramework.Controls.MetroTile();
            this.btnEstadistica = new MetroFramework.Controls.MetroTile();
            this.lblHoraNombre = new System.Windows.Forms.Label();
            this.tblPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.btnCabinas, 0, 0);
            this.tblPrincipal.Controls.Add(this.btnComputadoras, 0, 1);
            this.tblPrincipal.Controls.Add(this.btnDirectorio, 0, 2);
            this.tblPrincipal.Controls.Add(this.btnEstadistica, 0, 3);
            this.tblPrincipal.Location = new System.Drawing.Point(24, 64);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 4;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrincipal.Size = new System.Drawing.Size(250, 190);
            this.tblPrincipal.TabIndex = 0;
            // 
            // btnCabinas
            // 
            this.btnCabinas.ActiveControl = null;
            this.btnCabinas.Location = new System.Drawing.Point(3, 3);
            this.btnCabinas.Name = "btnCabinas";
            this.btnCabinas.Size = new System.Drawing.Size(244, 41);
            this.btnCabinas.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCabinas.TabIndex = 0;
            this.btnCabinas.Text = "Cabinas";
            this.btnCabinas.UseSelectable = true;
            this.btnCabinas.UseStyleColors = true;
            this.btnCabinas.Click += new System.EventHandler(this.btnCabinas_Click);
            // 
            // btnComputadoras
            // 
            this.btnComputadoras.ActiveControl = null;
            this.btnComputadoras.Location = new System.Drawing.Point(3, 50);
            this.btnComputadoras.Name = "btnComputadoras";
            this.btnComputadoras.Size = new System.Drawing.Size(244, 41);
            this.btnComputadoras.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnComputadoras.TabIndex = 1;
            this.btnComputadoras.Text = "Computadoras";
            this.btnComputadoras.UseSelectable = true;
            this.btnComputadoras.UseStyleColors = true;
            this.btnComputadoras.Click += new System.EventHandler(this.btnComputadoras_Click);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.ActiveControl = null;
            this.btnDirectorio.Location = new System.Drawing.Point(3, 97);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(244, 41);
            this.btnDirectorio.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.Text = "Directorio de clientes";
            this.btnDirectorio.UseSelectable = true;
            this.btnDirectorio.UseStyleColors = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.ActiveControl = null;
            this.btnEstadistica.Location = new System.Drawing.Point(3, 144);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(244, 43);
            this.btnEstadistica.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnEstadistica.TabIndex = 3;
            this.btnEstadistica.Text = "Estadísticas";
            this.btnEstadistica.UseSelectable = true;
            this.btnEstadistica.UseStyleColors = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // lblHoraNombre
            // 
            this.lblHoraNombre.AutoSize = true;
            this.lblHoraNombre.Location = new System.Drawing.Point(27, 292);
            this.lblHoraNombre.Name = "lblHoraNombre";
            this.lblHoraNombre.Size = new System.Drawing.Size(82, 13);
            this.lblHoraNombre.TabIndex = 1;
            this.lblHoraNombre.Text = "[Hora y nombre]";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 319);
            this.Controls.Add(this.lblHoraNombre);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "FrmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Locutorio";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tblPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private MetroFramework.Controls.MetroTile btnCabinas;
        private MetroFramework.Controls.MetroTile btnComputadoras;
        private MetroFramework.Controls.MetroTile btnDirectorio;
        private MetroFramework.Controls.MetroTile btnEstadistica;
        private System.Windows.Forms.Label lblHoraNombre;
    }
}