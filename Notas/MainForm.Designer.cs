namespace Notas
{
    partial class MainForm
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
            this.dlgImagen = new System.Windows.Forms.OpenFileDialog();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mBtnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mBtnBuscarArchivo = new MetroFramework.Controls.MetroButton();
            this.mTxtRuta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTxtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mBtnBuscar = new MetroFramework.Controls.MetroButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mLblNota = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgImagen
            // 
            this.dlgImagen.FileName = "openFileDialog1";
            this.dlgImagen.Filter = "Archivos de imágenes |*.jpg;*.jpeg;*.bmp";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(489, 437);
            this.metroTabControl1.TabIndex = 14;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mBtnGuardar);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.mBtnBuscarArchivo);
            this.metroTabPage1.Controls.Add(this.mTxtRuta);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.mTxtTitulo);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(481, 395);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Nueva nota";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mBtnGuardar
            // 
            this.mBtnGuardar.Location = new System.Drawing.Point(403, 366);
            this.mBtnGuardar.Name = "mBtnGuardar";
            this.mBtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.mBtnGuardar.TabIndex = 8;
            this.mBtnGuardar.Text = "&Guardar";
            this.mBtnGuardar.UseSelectable = true;
            this.mBtnGuardar.Click += new System.EventHandler(this.mBtnGuardar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 101);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(474, 259);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // mBtnBuscarArchivo
            // 
            this.mBtnBuscarArchivo.Location = new System.Drawing.Point(453, 72);
            this.mBtnBuscarArchivo.Name = "mBtnBuscarArchivo";
            this.mBtnBuscarArchivo.Size = new System.Drawing.Size(25, 23);
            this.mBtnBuscarArchivo.TabIndex = 6;
            this.mBtnBuscarArchivo.Text = "...";
            this.mBtnBuscarArchivo.UseSelectable = true;
            this.mBtnBuscarArchivo.Click += new System.EventHandler(this.mBtnBuscarArchivo_Click);
            // 
            // mTxtRuta
            // 
            // 
            // 
            // 
            this.mTxtRuta.CustomButton.Image = null;
            this.mTxtRuta.CustomButton.Location = new System.Drawing.Point(421, 1);
            this.mTxtRuta.CustomButton.Name = "";
            this.mTxtRuta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtRuta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtRuta.CustomButton.TabIndex = 1;
            this.mTxtRuta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtRuta.CustomButton.UseSelectable = true;
            this.mTxtRuta.CustomButton.Visible = false;
            this.mTxtRuta.Lines = new string[0];
            this.mTxtRuta.Location = new System.Drawing.Point(4, 72);
            this.mTxtRuta.MaxLength = 32767;
            this.mTxtRuta.Name = "mTxtRuta";
            this.mTxtRuta.PasswordChar = '\0';
            this.mTxtRuta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtRuta.SelectedText = "";
            this.mTxtRuta.SelectionLength = 0;
            this.mTxtRuta.SelectionStart = 0;
            this.mTxtRuta.ShortcutsEnabled = true;
            this.mTxtRuta.Size = new System.Drawing.Size(443, 23);
            this.mTxtRuta.TabIndex = 5;
            this.mTxtRuta.UseSelectable = true;
            this.mTxtRuta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtRuta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Ruta de imágen:";
            // 
            // mTxtTitulo
            // 
            // 
            // 
            // 
            this.mTxtTitulo.CustomButton.Image = null;
            this.mTxtTitulo.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.mTxtTitulo.CustomButton.Name = "";
            this.mTxtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtTitulo.CustomButton.TabIndex = 1;
            this.mTxtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtTitulo.CustomButton.UseSelectable = true;
            this.mTxtTitulo.CustomButton.Visible = false;
            this.mTxtTitulo.Lines = new string[0];
            this.mTxtTitulo.Location = new System.Drawing.Point(4, 24);
            this.mTxtTitulo.MaxLength = 32767;
            this.mTxtTitulo.Name = "mTxtTitulo";
            this.mTxtTitulo.PasswordChar = '\0';
            this.mTxtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtTitulo.SelectedText = "";
            this.mTxtTitulo.SelectionLength = 0;
            this.mTxtTitulo.SelectionStart = 0;
            this.mTxtTitulo.ShortcutsEnabled = true;
            this.mTxtTitulo.Size = new System.Drawing.Size(474, 23);
            this.mTxtTitulo.TabIndex = 3;
            this.mTxtTitulo.UseSelectable = true;
            this.mTxtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Titulo:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.Controls.Add(this.mBtnBuscar);
            this.metroTabPage2.Controls.Add(this.numericUpDown1);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(481, 395);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Consultar nota";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.mLblNota);
            this.metroPanel2.Controls.Add(this.pictureBox4);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 29);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(475, 363);
            this.metroPanel2.TabIndex = 12;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // mBtnBuscar
            // 
            this.mBtnBuscar.Location = new System.Drawing.Point(403, 3);
            this.mBtnBuscar.Name = "mBtnBuscar";
            this.mBtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.mBtnBuscar.TabIndex = 11;
            this.mBtnBuscar.Text = "&Buscar";
            this.mBtnBuscar.UseSelectable = true;
            this.mBtnBuscar.Click += new System.EventHandler(this.mBtnBuscar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(66, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(331, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "ID Nota:";
            // 
            // mLblNota
            // 
            this.mLblNota.AutoSize = true;
            this.mLblNota.Location = new System.Drawing.Point(3, 0);
            this.mLblNota.Name = "mLblNota";
            this.mLblNota.Size = new System.Drawing.Size(83, 19);
            this.mLblNota.TabIndex = 3;
            this.mLblNota.Text = "metroLabel4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 519);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "Notas";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgImagen;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton mBtnGuardar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton mBtnBuscarArchivo;
        private MetroFramework.Controls.MetroTextBox mTxtRuta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTxtTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton mBtnBuscar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel mLblNota;
    }
}

