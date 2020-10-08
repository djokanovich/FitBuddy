using System;
using System.Linq;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IPacienteRepositorio
    {
        Paciente ObtenerPacientePorUsuarioId(int usuarioId);
        Paciente CrearPaciente(Paciente paciente);
        Paciente ActualizarPaciente(int pacienteId);
        int GuardarCambios();
    }

    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly AppDbContext _dbContext;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public PacienteRepositorio(AppDbContext dbContext, IUsuarioRepositorio usuarioRepositorio)
        {
            _dbContext = dbContext;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Paciente ObtenerPacientePorUsuarioId(int usuarioId)
        {
            var paciente = _dbContext.Paciente.SingleOrDefault(p => p.Id == usuarioId);
            if (paciente == null)
            {
                paciente = new Paciente
                {
                    UsuarioId = usuarioId,
                    Usuario = _usuarioRepositorio.ObtenerUsuarioPorId(usuarioId),
                    FechaRegistroPerfil = DateTime.Now
                };
                CrearPaciente(paciente);
                GuardarCambios();
            }

            return paciente;
        }
        public Paciente CrearPaciente(Paciente paciente)
        {
            return _dbContext.Paciente.Add(paciente);
        }


        public Paciente ActualizarPaciente(int pacienteId)
        {
            var paciente = _dbContext.Paciente.SingleOrDefault(p => p.Id == pacienteId);
            _dbContext.Paciente.Attach(paciente);
            _dbContext.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
            return paciente;
        }

        public int GuardarCambios()
        {
            return _dbContext.SaveChanges();
        }
    }
}
