using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class PacienteRepositorio : RepositorioGenérico<Paciente>
    {
        public PacienteRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override Paciente AgregarNuevo(Paciente paciente)
        {
            paciente.Usuario = _dbContext.Usuarios.Find(paciente.UsuarioId);
            return base.AgregarNuevo(paciente);
        }
    }
}
