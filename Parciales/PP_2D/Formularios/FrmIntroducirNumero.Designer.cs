
namespace Formularios
{
    partial class FrmIntroducirNumero
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
            this.lblInstrucciones = new MetroFramework.Controls.MetroLabel();
            this.txtNumeroIntroducido = new MetroFramework.Controls.MetroTextBox();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(24, 52);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(138, 19);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "(12 cifras sin símbolos)";
            // 
            // txtNumeroIntroducido
            // 
            // 
            // 
            // 
            this.txtNumeroIntroducido.CustomButton.Image = null;
            this.txtNumeroIntroducido.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtNumeroIntroducido.CustomButton.Name = "";
            this.txtNumeroIntroducido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroIntroducido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroIntroducido.CustomButton.TabIndex = 1;
            this.txtNumeroIntroducido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroIntroducido.CustomButton.UseSelectable = true;
            this.txtNumeroIntroducido.CustomButton.Visible = false;
            this.txtNumeroIntroducido.Lines = new string[0];
            this.txtNumeroIntroducido.Location = new System.Drawing.Point(23, 84);
            this.txtNumeroIntroducido.MaxLength = 32767;
            this.txtNumeroIntroducido.Name = "txtNumeroIntroducido";
            this.txtNumeroIntroducido.PasswordChar = '\0';
            this.txtNumeroIntroducido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroIntroducido.SelectedText = "";
            this.txtNumeroIntroducido.SelectionLength = 0;
            this.txtNumeroIntroducido.SelectionStart = 0;
            this.txtNumeroIntroducido.ShortcutsEnabled = true;
            this.txtNumeroIntroducido.Size = new System.Drawing.Size(321, 23);
            this.txtNumeroIntroducido.TabIndex = 1;
            this.txtNumeroIntroducido.UseSelectable = true;
            this.txtNumeroIntroducido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroIntroducido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(106, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 117);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmIntroducirNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 155);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNumeroIntroducido);
            this.Controls.Add(this.lblInstrucciones);
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmIntroducirNumero";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Introduzca el número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInstrucciones;
        private MetroFramework.Controls.MetroTextBox txtNumeroIntroducido;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}