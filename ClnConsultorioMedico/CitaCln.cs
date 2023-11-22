using CadConsultorioMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioMedico
{
    public class CitaCln
    {
        public static int insertar(Cita cita)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                context.Cita.Add(cita);
                context.SaveChanges();
                return cita.id;
            }
        }

        public static int actualizar(Cita cita)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Cita.Find(cita.id);
                existente.horaCita = cita.horaCita;
                existente.fechaCita = cita.fechaCita;
                existente.motivo = cita.motivo;
                existente.cuenta = cita.cuenta;
                existente.quirofano = cita.quirofano;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                var existente = context.Cita.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Cita get(int id)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Cita.Find(id);
            }
        }

        public static List<Cita> listar()
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Cita.Where(x => x.estado != -1).ToList();
            }
        }

        //public static List<paPacienteListar_Result> listarPa(string parametro)
        //{
        //    using (var context = new ConsultorioMedicoEntities())
        //    {
        //        return context.paPacienteListar(parametro).ToList();
        //    }
        //}
    }
}
