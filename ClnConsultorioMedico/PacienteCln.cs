using CadConsultorioMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioMedico
{
    public class PacienteCln
    {
        public static int insertar(Paciente paciente)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();
                return paciente.id;
            }
        }

        public static int actualizar(Paciente paciente)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Paciente.Find(paciente.id);
                existente.cedulaIdentidad = paciente.cedulaIdentidad;
                existente.nombres = paciente.nombres;
                existente.apellidos = paciente.apellidos;
                existente.direccion = paciente.direccion;
                existente.telefono = paciente.telefono;
                existente.sexo = paciente.sexo;
                existente.fechaNacimiento = paciente.fechaNacimiento;
                existente.usuarioRegistro = paciente.usuarioRegistro;
                existente.estado = paciente.estado;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Paciente.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Paciente get(int id)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Paciente.Find(id);
            }
        }

        public static List<Paciente> listar()
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Paciente.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paPacienteListar_Result> listarPa(string parametro)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.paPacienteListar(parametro).ToList();
            }
        }
    }
}
