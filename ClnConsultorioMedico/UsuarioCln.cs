using CadConsultorioMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnConsultorioMedico
{
    public class UsuarioCln
    {
        public static Usuario validar(string nombreUsuario, string clave)
        {
            using (var context = new ConsultorioMedicoEntities())
            {
                return context.Usuario
                    .Where(x => x.nombreUsuario == nombreUsuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
}
