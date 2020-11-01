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
        DietaSemanal CrearDietaSemanal(int usuarioId);
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

        public DietaSemanal CrearDietaSemanal(int usuarioId)
        {
            var dietaSemanal = new DietaSemanal();

            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (pacienteAsociadoAUsuario == null)
                return dietaSemanal;

            // Buscar las comidas que no contengan las alergias del paciente.
            var comidas = _comidaRepositorio.BuscarPor(comida => (pacienteAsociadoAUsuario.Alergias & comida.Contiene) == 0);

            for (DayOfWeek dayOfWeek = DayOfWeek.Monday; dayOfWeek <= DayOfWeek.Friday; ++dayOfWeek)
            {
                foreach (TipoComida tipoComida in Enum.GetValues(typeof(TipoComida)))
                {
                    // Filtrar por tipo de comida (desayuno, almuerzo, etc.)
                    var comidasDeTipoComida = comidas.Where(c => (c.TipoComida & tipoComida) != 0).ToList();

                    var númeroAlAzar = _rngService.NúmeroAlAzar(comidasDeTipoComida.Count);
                    dietaSemanal[dayOfWeek, tipoComida] = comidasDeTipoComida[númeroAlAzar].Descripción;
                }
            }

            return dietaSemanal;
        }
    }
}
