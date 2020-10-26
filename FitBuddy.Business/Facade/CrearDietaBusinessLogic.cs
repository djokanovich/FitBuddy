﻿using System;
using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;

namespace FitBuddy.Business.Facade
{
    public interface ICrearDietaBusinessLogic
    {
        Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId);
        bool CrearOActualizarPaciente(int usuarioId, Paciente paciente);
    }

    public class CrearDietaBusinessLogic : ICrearDietaBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public CrearDietaBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            return pacienteAsociadoAUsuario;
        }

        public bool CrearOActualizarPaciente(int usuarioId, Paciente paciente)
        {
            if (paciente.Id == 0)
            {
                paciente.UsuarioId = usuarioId;
                paciente.FechaRegistroPerfil = DateTime.Now; // TODO: ¿Qué función cumple esta propiedad? ¿Es la fecha de última actualización?

                _pacienteRepositorio.AgregarNuevo(paciente);
            }
            else
            {
                _pacienteRepositorio.ActualizarExistente(paciente);
            }

            return _pacienteRepositorio.GuardarCambios() > 0;
        }
    }
}
