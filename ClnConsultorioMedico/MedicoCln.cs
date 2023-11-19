using CadConsultorioMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioMedico
{
    public class MedicoCln
    {
        public static int insertar(Medico medico)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                context.Medico.Add(medico);
                context.SaveChanges();
                return medico.id;
            }
        }

        public static int actualizar(Medico medico)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Medico.Find(medico.id);
                existente.cedulaIdentidad = medico.cedulaIdentidad;
                existente.nombres = medico.nombres;
                existente.apellidos = medico.apellidos;
                existente.direccion = medico.direccion;
                existente.telefono = medico.telefono;
                existente.sexo = medico.sexo;
                existente.matriculaProfesional = medico.matriculaProfesional;
                existente.fechaNacimiento = medico.fechaNacimiento;
                existente.usuarioRegistro = medico.usuarioRegistro;
                existente.estado = medico.estado;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Medico.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Medico get(int id)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Medico.Find(id);
            }
        }

        public static List<Medico> listar()
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Medico.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paMedicoListar_Result> listarPa(string parametro)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.paMedicoListar(parametro).ToList();
            }
        }
    }
}
