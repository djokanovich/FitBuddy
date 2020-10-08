using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorio
{
   public class PacienteDAL
    {
        public int CrearPaciente(Paciente paciente)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Paciente.Add(paciente);
                return dbContext.SaveChanges();
            }
        }

        public Paciente ObtenerPaciente(int usuarioId)
        {
            using (var dbContext = new AppDbContext())
            {
                var paciente = dbContext.Paciente.SingleOrDefault(p => p.Id == usuarioId);
                if (paciente == null)
                {
                    var usuarioDAL = new UsuarioDAL();
                    var usuario = usuarioDAL.ObtenerUsuario(usuarioId);
                    paciente = new Paciente
                    {
                        UsuarioId = usuarioId,
                        Usuario = usuario
                    };
                    CrearPaciente(paciente);
                }

                return paciente;
            }
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Paciente.Attach(paciente);
                dbContext.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
