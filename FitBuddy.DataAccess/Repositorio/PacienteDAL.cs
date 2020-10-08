using System.Linq;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IPacienteDAL
    {
        void ActualizarPaciente(Paciente paciente);
        Paciente CrearPaciente(Paciente paciente);
        int GuardarCambios();
        Paciente ObtenerPacientePorId(int usuarioId);
    }

    public class PacienteDAL : IPacienteDAL
    {
        private readonly AppDbContext _dbContext;

        public PacienteDAL(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Paciente CrearPaciente(Paciente paciente)
        {
            return _dbContext.Paciente.Add(paciente);
        }

        public Paciente ObtenerPacientePorId(int usuarioId)
        {
            var paciente = _dbContext.Paciente.SingleOrDefault(p => p.Id == usuarioId);
            if (paciente == null)
            {
                var usuarioDAL = new UsuarioDAL(_dbContext); // TODO: Resolver dinámicamente.
                var usuario = usuarioDAL.ObtenerUsuarioPorId(usuarioId);
                paciente = new Paciente
                {
                    UsuarioId = usuarioId,
                    Usuario = usuario
                };
                CrearPaciente(paciente);
            }

            return paciente;
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            _dbContext.Paciente.Attach(paciente);
            _dbContext.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
        }

        public int GuardarCambios()
        {
            return _dbContext.SaveChanges();
        }
    }
}
