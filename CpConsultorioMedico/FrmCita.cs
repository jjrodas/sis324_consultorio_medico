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
    public partial class FrmCita : Form
    {
        FrmPrincipal frmprincipal;
        public FrmCita(FrmPrincipal frmprincipal)
        {
            InitializeComponent();
            this.frmprincipal = frmprincipal;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCita_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmprincipal.Visible = true;
        }

        private void lblCedulaIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void FrmCita_Load(object sender, EventArgs e)
        {
            Size = new Size(916, 359);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(916, 554);
            txtHoraCita.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(916, 359);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
