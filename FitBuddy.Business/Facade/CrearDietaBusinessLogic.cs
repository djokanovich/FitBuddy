using System;
using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICrearDietaBusinessLogic
    {
        bool CrearOActualizarPaciente(int usuarioId, Paciente paciente);
    }

    public class CrearDietaBusinessLogic : ICrearDietaBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public CrearDietaBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public bool CrearOActualizarPaciente(int usuarioId, Paciente paciente)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (pacienteAsociadoAUsuario == null)
            {
                paciente.UsuarioId = usuarioId;
                paciente.FechaRegistroPerfil = DateTime.Now; // TODO: ¿Qué función cumple esta propiedad? ¿Es la fecha de última actualización?

                _pacienteRepositorio.AgregarNuevo(paciente);
            }
            else
            {
                paciente.Id = pacienteAsociadoAUsuario.Id;
                _pacienteRepositorio.ActualizarExistente(paciente);
            }

            return _pacienteRepositorio.GuardarCambios() > 0;
        }
    }
}
