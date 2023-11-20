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
    public partial class FrmMedico : Form
    {
        bool esNuevo = false;
        public FrmMedico()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var medicos = MedicoCln.listarPa(txtParametro.Text.Trim());
            dgvListaMedicos.DataSource = medicos;
            dgvListaMedicos.Columns["id"].Visible = false;
            dgvListaMedicos.Columns["estado"].Visible = false;
            dgvListaMedicos.Columns["cedulaIdentidad"].HeaderText = "CI";
            dgvListaMedicos.Columns["nombres"].HeaderText = "Nombres";
            dgvListaMedicos.Columns["apellidos"].HeaderText = "Apellidos";
            dgvListaMedicos.Columns["direccion"].HeaderText = "Dirección";
            dgvListaMedicos.Columns["telefono"].HeaderText = "N° de Teléfono";
            dgvListaMedicos.Columns["sexo"].HeaderText = "Sexo";
            dgvListaMedicos.Columns["matriculaProfesional"].HeaderText = "Matrícula Profesional";
            dgvListaMedicos.Columns["fechaNacimiento"].HeaderText = "Fecha de nacimineto";
            dgvListaMedicos.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvListaMedicos.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";
            btnEditar.Enabled = medicos.Count > 0;
            btnEliminar.Enabled = medicos.Count > 0;
            if (medicos.Count > 0) dgvListaMedicos.Rows[0].Cells["cedulaIdentidad"].Selected = true;
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            Size = new Size(916, 390);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(916, 593);
            txtCedulaIdentidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(916, 593);

            int index = dgvListaMedicos.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaMedicos.Rows[index].Cells["id"].Value);
            var medico = MedicoCln.get(id);
            txtCedulaIdentidad.Text = medico.cedulaIdentidad;
            txtNombres.Text = medico.nombres;
            txtApellidos.Text = medico.apellidos;
            txtDireccion.Text = medico.direccion;
            txtTelefono.Text = Convert.ToString(medico.telefono);
            cbxSexo.Text = medico.sexo;
            txtMatriculaProfesional.Text = medico.matriculaProfesional;
            dtpFechaNacimiento.Value = medico.fechaNacimiento;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaMedicos.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaMedicos.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvListaMedicos.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            string nombres = dgvListaMedicos.Rows[index].Cells["nombres"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja al médico con la cédula de identidad {cedulaIdentidad} y nombre {nombres}?",
                "::: Consultorio Médico - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                PacienteCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Médico dado de baja correctamente", "::: Consultorio Médico - Mensaje :::",
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
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxSexo.SelectedIndex = -1;
            txtMatriculaProfesional.Text = string.Empty;
            dtpFechaNacimiento.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(916, 390);
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
            erpDireccion.SetError(txtDireccion, "");
            erpTelefono.SetError(txtTelefono, "");
            erpSexo.SetError(cbxSexo, "");
            erpMatriculaProfesional.SetError(txtMatriculaProfesional, "");
            erpFechaNacimiento.SetError(dtpFechaNacimiento, "");
            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo cédula de identidad del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                esValido = false;
                erpNombres.SetError(txtNombres, "El campo nombre o nombres del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtApellidos, "El campo apellido o apellidos del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                esValido = false;
                erpDireccion.SetError(txtDireccion, "El campo dirección del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo teléfono del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(cbxSexo.Text))
            {
                esValido = false;
                erpSexo.SetError(cbxSexo, "El campo sexo del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtMatriculaProfesional.Text))
            {
                esValido = false;
                erpMatriculaProfesional.SetError(txtTelefono, "El campo mátricula profesional del médico es obligatorio.");
            }
            if (string.IsNullOrEmpty(dtpFechaNacimiento.Text))
            {
                esValido = false;
                erpFechaNacimiento.SetError(dtpFechaNacimiento, "El campo fecha de nacimiento del médico es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var medico = new Medico();
                medico.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                medico.nombres = txtNombres.Text.Trim();
                medico.apellidos = txtApellidos.Text.Trim();
                medico.direccion = txtDireccion.Text.Trim();
                medico.telefono = Convert.ToInt32(txtTelefono.Text);
                medico.sexo = cbxSexo.Text.Trim();
                medico.matriculaProfesional = txtMatriculaProfesional.Text.Trim();
                medico.fechaNacimiento = dtpFechaNacimiento.Value;
                medico.usuarioRegistro = "usrSIS324";

                if (esNuevo)
                {
                    medico.fechaRegistro = DateTime.Now;
                    medico.estado = 1;
                    MedicoCln.insertar(medico);
                }
                else
                {
                    int index = dgvListaMedicos.CurrentCell.RowIndex;
                    medico.id = Convert.ToInt32(dgvListaMedicos.Rows[index].Cells["id"].Value);
                    MedicoCln.actualizar(medico);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Médico registrado correctamente", "::: Consultorio Médico - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
