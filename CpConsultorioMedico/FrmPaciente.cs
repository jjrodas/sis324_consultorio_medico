using CadConsultorioMedico;
using ClnConsultorioMedico;
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
    public partial class FrmPaciente : Form
    {
        FrmPrincipal frmprincipal;
        bool esNuevo = false;
        public FrmPaciente(FrmPrincipal frmprincipal)
        {
            InitializeComponent();
            this.frmprincipal = frmprincipal;
        }
        private void listar()
        {
            var pacientes = PacienteCln.listarPa(txtParametro.Text.Trim());
            dgvListaPacientes.DataSource = pacientes;
            dgvListaPacientes.Columns["id"].Visible = false;
            dgvListaPacientes.Columns["estado"].Visible = false;
            dgvListaPacientes.Columns["cedulaIdentidad"].HeaderText = "CI";
            dgvListaPacientes.Columns["nombres"].HeaderText = "Nombres";
            dgvListaPacientes.Columns["apellidos"].HeaderText = "Apellidos";
            dgvListaPacientes.Columns["edad"].HeaderText = "Edad";
            dgvListaPacientes.Columns["direccion"].HeaderText = "Dirección";
            dgvListaPacientes.Columns["telefono"].HeaderText = "N° de Teléfono";
            dgvListaPacientes.Columns["sexo"].HeaderText = "Sexo";
            dgvListaPacientes.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvListaPacientes.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = pacientes.Count > 0;
            btnEliminar.Enabled = pacientes.Count > 0;
            if (pacientes.Count > 0) dgvListaPacientes.Rows[0].Cells["cedulaIdentidad"].Selected = true;
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            Size = new Size(916, 359);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(916, 554);
            txtCedulaIdentidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(916, 554);

            int index = dgvListaPacientes.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
            var paciente = PacienteCln.get(id);
            txtCedulaIdentidad.Text = paciente.cedulaIdentidad;
            txtNombres.Text = paciente.nombres;
            txtApellidos.Text = paciente.apellidos;
            txtDireccion.Text = paciente.direccion;
            txtEdad.Text = Convert.ToString(paciente.edad);
            txtTelefono.Text = Convert.ToString(paciente.telefono);
            cbxSexo.Text = paciente.sexo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaPacientes.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvListaPacientes.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            string nombres = dgvListaPacientes.Rows[index].Cells["nombres"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el paciente con la cédula de identidad {cedulaIdentidad} y nombre {nombres}?",
                "::: Consultorio Médico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PacienteCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Paciente dado de baja correctamente", "::: Consultorio Médico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void limpiar()
        {
            txtCedulaIdentidad.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtEdad.Text = "0";
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxSexo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(916, 359);
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtApellidos, "");
            erpEdad.SetError(txtEdad, "");
            erpDireccion.SetError(txtDireccion, "");
            erpTelefono.SetError(txtTelefono, "");
            erpSexo.SetError(cbxSexo, "");
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo cédula de identidad del paciente es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                esValido = false;
                erpNombres.SetError(txtNombres, "El campo nombre o nombres del paciente es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtApellidos, "El campo apellido o apellidos del paciente es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                esValido = false;
                erpEdad.SetError(txtEdad, "El campo edad del paciente es obligatorio.");
            }
            if (Convert.ToInt32(txtEdad.Text) < 18)
            {
                esValido = false;
                erpEdad.SetError(txtEdad, "El paciente debe ser mayor de edad.");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo dirección del paciente es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo teléfono del paciente es obligatorio.");
            }
            if (string.IsNullOrEmpty(cbxSexo.Text))
            {
                esValido = false;
                erpSexo.SetError(cbxSexo, "El campo sexo del paciente es obligatorio.");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var paciente = new Paciente();
                paciente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                paciente.nombres = txtNombres.Text.Trim();
                paciente.apellidos = txtApellidos.Text.Trim();
                paciente.edad = Convert.ToInt32(txtEdad.Text);
                paciente.direccion = txtDireccion.Text.Trim();
                paciente.telefono = Convert.ToInt32(txtTelefono.Text);
                paciente.sexo = cbxSexo.Text.Trim();
                paciente.usuarioRegistro = "UsrSIS324";

                if (esNuevo)
                {
                    paciente.fechaRegistro = DateTime.Now;
                    paciente.estado = 1;
                    PacienteCln.insertar(paciente);
                }
                else
                {
                    int index = dgvListaPacientes.CurrentCell.RowIndex;
                    paciente.id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
                    PacienteCln.actualizar(paciente);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Paciente registrado correctamente", "::: Consultorio Médico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmprincipal.Visible = true;
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FrmMedico(frmprincipal).ShowDialog();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(916, 554);
            txtCedulaIdentidad.Focus();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(916, 554);

            int index = dgvListaPacientes.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
            var paciente = PacienteCln.get(id);
            txtCedulaIdentidad.Text = paciente.cedulaIdentidad;
            txtNombres.Text = paciente.nombres;
            txtApellidos.Text = paciente.apellidos;
            txtDireccion.Text = paciente.direccion;
            txtEdad.Text = Convert.ToString(paciente.edad);
            txtTelefono.Text = Convert.ToString(paciente.telefono);
            cbxSexo.Text = paciente.sexo;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int index = dgvListaPacientes.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvListaPacientes.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            string nombres = dgvListaPacientes.Rows[index].Cells["nombres"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el paciente con la cédula de identidad {cedulaIdentidad} y nombre {nombres}?",
                "::: Consultorio Médico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PacienteCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Paciente dado de baja correctamente", "::: Consultorio Médico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                var paciente = new Paciente();
                paciente.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                paciente.nombres = txtNombres.Text.Trim();
                paciente.apellidos = txtApellidos.Text.Trim();
                paciente.edad = Convert.ToInt32(txtEdad.Text);
                paciente.direccion = txtDireccion.Text.Trim();
                paciente.telefono = Convert.ToInt32(txtTelefono.Text);
                paciente.sexo = cbxSexo.Text.Trim();
                paciente.usuarioRegistro = "UsrSIS324";

                if (esNuevo)
                {
                    paciente.fechaRegistro = DateTime.Now;
                    paciente.estado = 1;
                    PacienteCln.insertar(paciente);
                }
                else
                {
                    int index = dgvListaPacientes.CurrentCell.RowIndex;
                    paciente.id = Convert.ToInt32(dgvListaPacientes.Rows[index].Cells["id"].Value);
                    PacienteCln.actualizar(paciente);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Paciente registrado correctamente", "::: Consultorio Médico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Size = new Size(916, 359);
            limpiar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            new FrmCita(frmprincipal).ShowDialog();
        }
    }
}
