using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        #region Procedimientos
        private void CustomizeDesing()
        {
            panelPacienteSub.Visible=false;
            panelAdmisionSub.Visible=false;
            panelMedicoSub.Visible=false;
        }

        private void HideSubMenu()
        {
            if (panelPacienteSub.Visible==true)
                panelPacienteSub.Visible = false;
            if (panelAdmisionSub.Visible==true)
                panelAdmisionSub.Visible = false;
            if (panelMedicoSub.Visible==true)
                panelMedicoSub.Visible = false;
        }

        private void ShowSubMenu(Panel Sub)
        {
            if (Sub.Visible == false)
            {
                HideSubMenu();
                Sub.Visible = true;
            }
            else
            {
                Sub.Visible = false;
            }
        }
        #endregion

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPacienteSub);
        }

        #region SubMenú de Pacientes
        private void btnNuevoIng_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnHistorialPac_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private void btnAdmision_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAdmisionSub);
        }

        #region SubMenú de Admisiones
        private void btnNuevaAdmision_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnUltimasAdm_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnHistorialAdm_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMedicoSub);
        }

        #region SubMenú Médicos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnListadoMed_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion
    }
}
