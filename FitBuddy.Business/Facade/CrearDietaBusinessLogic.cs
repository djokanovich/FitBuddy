using System;
using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICrearDietaBusinessLogic
    {
        int ActualizarPaciente(int pacienteId);
        Paciente ObtenerOCrearPacientePorUsuarioId(int usuarioId);
    }

    public class CrearDietaBusinessLogic : ICrearDietaBusinessLogic
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CrearDietaBusinessLogic(IPacienteRepositorio pacienteRepositorio, IUsuarioRepositorio usuarioRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Paciente ObtenerOCrearPacientePorUsuarioId(int usuarioId)
        {
            var paciente = _pacienteRepositorio.ObtenerPacientePorUsuarioId(usuarioId);
            if (paciente == null)
            {
                paciente = new Paciente
                {
                    UsuarioId = usuarioId,
                    Usuario = _usuarioRepositorio.ObtenerUsuarioPorId(usuarioId),
                    FechaRegistroPerfil = DateTime.Now
                };

                _pacienteRepositorio.CrearPaciente(paciente);
                _pacienteRepositorio.GuardarCambios();
            }

            return paciente;
        }
        public int ActualizarPaciente(int pacienteId)
        {
            _pacienteRepositorio.ActualizarPaciente(pacienteId);
            return _pacienteRepositorio.GuardarCambios();
        }
    }
}
