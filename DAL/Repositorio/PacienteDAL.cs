using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL.Repositorio
{
   public class PacienteDAL
    {
        public Paciente CrearPaciente(Paciente paciente)
        {
            using (var dbContext = new AppDbContext())
            {
                var pacienteNuevo = dbContext.Paciente.Add(paciente);
                return pacienteNuevo;
            }
        }

        public int GuardarCambios()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.SaveChanges();
            }
        }
    }

}
