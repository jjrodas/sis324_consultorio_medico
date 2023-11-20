using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpConsultorioMedico
{
    public partial class FrmPrincipal : Form
    {
        FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FrmPaciente(this).ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FrmMedico(this).ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }
    }
}
