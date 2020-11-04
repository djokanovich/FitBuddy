using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public override IEnumerable<Paciente> Todos()
        {
            return _dbContext.Paciente
                .Include(p => p.HistorialPaciente)
                .AsEnumerable();
        }

        public override IEnumerable<Paciente> BuscarPor(Expression<Func<Paciente, bool>> predicado)
        {
            return _dbContext.Paciente
                .Include(p => p.HistorialPaciente)
                .Where(predicado)
                .AsEnumerable();
        }
    }
}
