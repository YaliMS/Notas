namespace Notas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMnuLateral = new System.Windows.Forms.Panel();
            this.panelMedicoSub = new System.Windows.Forms.Panel();
            this.btnListadoMed = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.panelAdmisionSub = new System.Windows.Forms.Panel();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnHistorialAdm = new System.Windows.Forms.Button();
            this.btnUltimasAdm = new System.Windows.Forms.Button();
            this.btnCrearCita = new System.Windows.Forms.Button();
            this.btnNuevaAdmision = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.panelPacienteSub = new System.Windows.Forms.Panel();
            this.btnHistorialPac = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnNuevoIng = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMnuLateral.SuspendLayout();
            this.panelMedicoSub.SuspendLayout();
            this.panelAdmisionSub.SuspendLayout();
            this.panelPacienteSub.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMnuLateral
            // 
            this.panelMnuLateral.AutoScroll = true;
            this.panelMnuLateral.BackColor = System.Drawing.Color.Black;
            this.panelMnuLateral.Controls.Add(this.panelMedicoSub);
            this.panelMnuLateral.Controls.Add(this.btnMedicos);
            this.panelMnuLateral.Controls.Add(this.panelAdmisionSub);
            this.panelMnuLateral.Controls.Add(this.btnAdmision);
            this.panelMnuLateral.Controls.Add(this.panelPacienteSub);
            this.panelMnuLateral.Controls.Add(this.btnPaciente);
            this.panelMnuLateral.Controls.Add(this.panelLogo);
            this.panelMnuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMnuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMnuLateral.Name = "panelMnuLateral";
            this.panelMnuLateral.Size = new System.Drawing.Size(220, 718);
            this.panelMnuLateral.TabIndex = 0;
            // 
            // panelMedicoSub
            // 
            this.panelMedicoSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMedicoSub.Controls.Add(this.btnListadoMed);
            this.panelMedicoSub.Controls.Add(this.btnEspecialidades);
            this.panelMedicoSub.Controls.Add(this.btnRegistrar);
            this.panelMedicoSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedicoSub.Location = new System.Drawing.Point(0, 561);
            this.panelMedicoSub.Name = "panelMedicoSub";
            this.panelMedicoSub.Size = new System.Drawing.Size(220, 121);
            this.panelMedicoSub.TabIndex = 7;
            // 
            // btnListadoMed
            // 
            this.btnListadoMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoMed.FlatAppearance.BorderSize = 0;
            this.btnListadoMed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnListadoMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoMed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListadoMed.Location = new System.Drawing.Point(0, 80);
            this.btnListadoMed.Name = "btnListadoMed";
            this.btnListadoMed.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListadoMed.Size = new System.Drawing.Size(220, 40);
            this.btnListadoMed.TabIndex = 2;
            this.btnListadoMed.Text = "Listado de Médicos";
            this.btnListadoMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoMed.UseVisualStyleBackColor = true;
            this.btnListadoMed.Click += new System.EventHandler(this.btnListadoMed_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnEspecialidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEspecialidades.Location = new System.Drawing.Point(0, 40);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEspecialidades.Size = new System.Drawing.Size(220, 40);
            this.btnEspecialidades.TabIndex = 1;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistrar.Size = new System.Drawing.Size(220, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedicos.Location = new System.Drawing.Point(0, 516);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedicos.Size = new System.Drawing.Size(220, 45);
            this.btnMedicos.TabIndex = 6;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // panelAdmisionSub
            // 
            this.panelAdmisionSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAdmisionSub.Controls.Add(this.btnCalendario);
            this.panelAdmisionSub.Controls.Add(this.btnHistorialAdm);
            this.panelAdmisionSub.Controls.Add(this.btnUltimasAdm);
            this.panelAdmisionSub.Controls.Add(this.btnCrearCita);
            this.panelAdmisionSub.Controls.Add(this.btnNuevaAdmision);
            this.panelAdmisionSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmisionSub.Location = new System.Drawing.Point(0, 311);
            this.panelAdmisionSub.Name = "panelAdmisionSub";
            this.panelAdmisionSub.Size = new System.Drawing.Size(220, 205);
            this.panelAdmisionSub.TabIndex = 5;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalendario.Location = new System.Drawing.Point(0, 160);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCalendario.Size = new System.Drawing.Size(220, 40);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnHistorialAdm
            // 
            this.btnHistorialAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialAdm.FlatAppearance.BorderSize = 0;
            this.btnHistorialAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnHistorialAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialAdm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistorialAdm.Location = new System.Drawing.Point(0, 120);
            this.btnHistorialAdm.Name = "btnHistorialAdm";
            this.btnHistorialAdm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorialAdm.Size = new System.Drawing.Size(220, 40);
            this.btnHistorialAdm.TabIndex = 3;
            this.btnHistorialAdm.Text = "Historial de Admisiones";
            this.btnHistorialAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialAdm.UseVisualStyleBackColor = true;
            this.btnHistorialAdm.Click += new System.EventHandler(this.btnHistorialAdm_Click);
            // 
            // btnUltimasAdm
            // 
            this.btnUltimasAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUltimasAdm.FlatAppearance.BorderSize = 0;
            this.btnUltimasAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnUltimasAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimasAdm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUltimasAdm.Location = new System.Drawing.Point(0, 80);
            this.btnUltimasAdm.Name = "btnUltimasAdm";
            this.btnUltimasAdm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUltimasAdm.Size = new System.Drawing.Size(220, 40);
            this.btnUltimasAdm.TabIndex = 2;
            this.btnUltimasAdm.Text = "Ultimas Admisiones";
            this.btnUltimasAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimasAdm.UseVisualStyleBackColor = true;
            this.btnUltimasAdm.Click += new System.EventHandler(this.btnUltimasAdm_Click);
            // 
            // btnCrearCita
            // 
            this.btnCrearCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCita.FlatAppearance.BorderSize = 0;
            this.btnCrearCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnCrearCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCita.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearCita.Location = new System.Drawing.Point(0, 40);
            this.btnCrearCita.Name = "btnCrearCita";
            this.btnCrearCita.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCrearCita.Size = new System.Drawing.Size(220, 40);
            this.btnCrearCita.TabIndex = 1;
            this.btnCrearCita.Text = "Crear Cita";
            this.btnCrearCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCita.UseVisualStyleBackColor = true;
            this.btnCrearCita.Click += new System.EventHandler(this.btnCrearCita_Click);
            // 
            // btnNuevaAdmision
            // 
            this.btnNuevaAdmision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaAdmision.FlatAppearance.BorderSize = 0;
            this.btnNuevaAdmision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnNuevaAdmision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAdmision.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaAdmision.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaAdmision.Name = "btnNuevaAdmision";
            this.btnNuevaAdmision.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevaAdmision.Size = new System.Drawing.Size(220, 40);
            this.btnNuevaAdmision.TabIndex = 0;
            this.btnNuevaAdmision.Text = "Nueva Admisión";
            this.btnNuevaAdmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAdmision.UseVisualStyleBackColor = true;
            this.btnNuevaAdmision.Click += new System.EventHandler(this.btnNuevaAdmision_Click);
            // 
            // btnAdmision
            // 
            this.btnAdmision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmision.FlatAppearance.BorderSize = 0;
            this.btnAdmision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.btnAdmision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmision.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmision.Location = new System.Drawing.Point(0, 266);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmision.Size = new System.Drawing.Size(220, 45);
            this.btnAdmision.TabIndex = 4;
            this.btnAdmision.Text = "Admisión y Citas";
            this.btnAdmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmision.UseVisualStyleBackColor = true;
            this.btnAdmision.Click += new System.EventHandler(this.btnAdmision_Click);
            // 
            // panelPacienteSub
            // 
            this.panelPacienteSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPacienteSub.Controls.Add(this.btnHistorialPac);
            this.panelPacienteSub.Controls.Add(this.btnListado);
            this.panelPacienteSub.Controls.Add(this.btnNuevoIng);
            this.panelPacienteSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacienteSub.Location = new System.Drawing.Point(0, 145);
            this.panelPacienteSub.Name = "panelPacienteSub";
            this.panelPacienteSub.Size = new System.Drawing.Size(220, 121);
            this.panelPacienteSub.TabIndex = 3;
            // 
            // btnHistorialPac
            // 
            this.btnHistorialPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialPac.FlatAppearance.BorderSize = 0;
            this.btnHistorialPac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnHistorialPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPac.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistorialPac.Location = new System.Drawing.Point(0, 80);
            this.btnHistorialPac.Name = "btnHistorialPac";
            this.btnHistorialPac.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistorialPac.Size = new System.Drawing.Size(220, 40);
            this.btnHistorialPac.TabIndex = 2;
            this.btnHistorialPac.Text = "Historial por Paciente";
            this.btnHistorialPac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPac.UseVisualStyleBackColor = true;
            this.btnHistorialPac.Click += new System.EventHandler(this.btnHistorialPac_Click);
            // 
            // btnListado
            // 
            this.btnListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListado.FlatAppearance.BorderSize = 0;
            this.btnListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListado.Location = new System.Drawing.Point(0, 40);
            this.btnListado.Name = "btnListado";
            this.btnListado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListado.Size = new System.Drawing.Size(220, 40);
            this.btnListado.TabIndex = 1;
            this.btnListado.Text = "Listado";
            this.btnListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnNuevoIng
            // 
            this.btnNuevoIng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoIng.FlatAppearance.BorderSize = 0;
            this.btnNuevoIng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(152)))), ((int)(((byte)(185)))));
            this.btnNuevoIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoIng.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoIng.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoIng.Name = "btnNuevoIng";
            this.btnNuevoIng.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoIng.Size = new System.Drawing.Size(220, 40);
            this.btnNuevoIng.TabIndex = 0;
            this.btnNuevoIng.Text = "Nuevo Ingreso";
            this.btnNuevoIng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoIng.UseVisualStyleBackColor = true;
            this.btnNuevoIng.Click += new System.EventHandler(this.btnNuevoIng_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaciente.Location = new System.Drawing.Point(0, 100);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(220, 45);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10);
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 718);
            this.Controls.Add(this.panelMnuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 718);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panelMnuLateral.ResumeLayout(false);
            this.panelMedicoSub.ResumeLayout(false);
            this.panelAdmisionSub.ResumeLayout(false);
            this.panelPacienteSub.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMnuLateral;
        private System.Windows.Forms.Panel panelPacienteSub;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnNuevoIng;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelAdmisionSub;
        private System.Windows.Forms.Button btnHistorialAdm;
        private System.Windows.Forms.Button btnUltimasAdm;
        private System.Windows.Forms.Button btnCrearCita;
        private System.Windows.Forms.Button btnNuevaAdmision;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Button btnHistorialPac;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Panel panelMedicoSub;
        private System.Windows.Forms.Button btnListadoMed;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.PictureBox picLogo;
    }
}