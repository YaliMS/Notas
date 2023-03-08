namespace Notas
{
    partial class UserForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.mTxtClave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mBtnVerificar = new MetroFramework.Controls.MetroButton();
            this.mBtnSave = new MetroFramework.Controls.MetroButton();
            this.mBtnCerrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Usuario:";
            // 
            // mTxtUsuario
            // 
            // 
            // 
            // 
            this.mTxtUsuario.CustomButton.Image = null;
            this.mTxtUsuario.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mTxtUsuario.CustomButton.Name = "";
            this.mTxtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtUsuario.CustomButton.TabIndex = 1;
            this.mTxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtUsuario.CustomButton.UseSelectable = true;
            this.mTxtUsuario.CustomButton.Visible = false;
            this.mTxtUsuario.Lines = new string[0];
            this.mTxtUsuario.Location = new System.Drawing.Point(23, 82);
            this.mTxtUsuario.MaxLength = 32767;
            this.mTxtUsuario.Name = "mTxtUsuario";
            this.mTxtUsuario.PasswordChar = '\0';
            this.mTxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtUsuario.SelectedText = "";
            this.mTxtUsuario.SelectionLength = 0;
            this.mTxtUsuario.SelectionStart = 0;
            this.mTxtUsuario.ShortcutsEnabled = true;
            this.mTxtUsuario.Size = new System.Drawing.Size(156, 23);
            this.mTxtUsuario.TabIndex = 7;
            this.mTxtUsuario.UseSelectable = true;
            this.mTxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxtClave
            // 
            // 
            // 
            // 
            this.mTxtClave.CustomButton.Image = null;
            this.mTxtClave.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mTxtClave.CustomButton.Name = "";
            this.mTxtClave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtClave.CustomButton.TabIndex = 1;
            this.mTxtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtClave.CustomButton.UseSelectable = true;
            this.mTxtClave.CustomButton.Visible = false;
            this.mTxtClave.Lines = new string[0];
            this.mTxtClave.Location = new System.Drawing.Point(23, 130);
            this.mTxtClave.MaxLength = 32767;
            this.mTxtClave.Name = "mTxtClave";
            this.mTxtClave.PasswordChar = '*';
            this.mTxtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtClave.SelectedText = "";
            this.mTxtClave.SelectionLength = 0;
            this.mTxtClave.SelectionStart = 0;
            this.mTxtClave.ShortcutsEnabled = true;
            this.mTxtClave.Size = new System.Drawing.Size(156, 23);
            this.mTxtClave.TabIndex = 9;
            this.mTxtClave.UseSelectable = true;
            this.mTxtClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // mBtnVerificar
            // 
            this.mBtnVerificar.Location = new System.Drawing.Point(23, 159);
            this.mBtnVerificar.Name = "mBtnVerificar";
            this.mBtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.mBtnVerificar.TabIndex = 10;
            this.mBtnVerificar.Text = "&Verificar";
            this.mBtnVerificar.UseSelectable = true;
            this.mBtnVerificar.Click += new System.EventHandler(this.mBtnVerificar_Click);
            // 
            // mBtnSave
            // 
            this.mBtnSave.Location = new System.Drawing.Point(104, 159);
            this.mBtnSave.Name = "mBtnSave";
            this.mBtnSave.Size = new System.Drawing.Size(75, 23);
            this.mBtnSave.TabIndex = 11;
            this.mBtnSave.Text = "&Guardar";
            this.mBtnSave.UseSelectable = true;
            this.mBtnSave.Click += new System.EventHandler(this.mBtnSave_Click);
            // 
            // mBtnCerrar
            // 
            this.mBtnCerrar.Location = new System.Drawing.Point(57, 188);
            this.mBtnCerrar.Name = "mBtnCerrar";
            this.mBtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.mBtnCerrar.TabIndex = 12;
            this.mBtnCerrar.Text = "&Cerrar";
            this.mBtnCerrar.UseSelectable = true;
            this.mBtnCerrar.Click += new System.EventHandler(this.mBtnCerrar_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 226);
            this.ControlBox = false;
            this.Controls.Add(this.mBtnCerrar);
            this.Controls.Add(this.mBtnSave);
            this.Controls.Add(this.mBtnVerificar);
            this.Controls.Add(this.mTxtClave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mTxtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserForm";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTxtUsuario;
        private MetroFramework.Controls.MetroTextBox mTxtClave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mBtnVerificar;
        private MetroFramework.Controls.MetroButton mBtnSave;
        private MetroFramework.Controls.MetroButton mBtnCerrar;
    }
}