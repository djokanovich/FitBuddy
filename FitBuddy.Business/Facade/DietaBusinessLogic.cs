using Common.Utilidades;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using System;
using System.Linq;

namespace FitBuddy.Business.Facade
{
    public interface IDietaBusinessLogic
    {
        string ElegirAlimentoAlAzar(TipoComida tipoComida, int usuarioId);
    }

    public class DietaBusinessLogic : IDietaBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;
        private readonly IRepositorio<Comida> _comidaRepositorio;
        private readonly RandomNumberGeneratorService _rngService;

        public DietaBusinessLogic(IRepositorio<Paciente> pacienteRepositorio, IRepositorio<Comida> comidaRepositorio, RandomNumberGeneratorService rngService)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _comidaRepositorio = comidaRepositorio;
            _rngService = rngService;
        }

        public string ElegirAlimentoAlAzar(TipoComida tipoComida, int usuarioId)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (pacienteAsociadoAUsuario == null)
            {
                return string.Empty;
            }

            // Buscar las comidas que no contengan las alergias del paciente.
            var comidas = _comidaRepositorio.BuscarPor(comida => (pacienteAsociadoAUsuario.Alergias & comida.Contiene) == 0 &&
                    (comida.TipoComida & tipoComida) != 0)
                .ToList();

            var indice = _rngService.NúmeroAlAzar(comidas.Count);
            return comidas[indice].Descripción;
        }
    }
}
