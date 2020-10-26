using FitBuddy.DataAccess.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business.Facade
{
    public interface IDietaBusinessLogic
    {
        string ElegirAlimentoAlAzar(int userid);
    }

    public class DietaBusinessLogic : IDietaBusinessLogic
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        private readonly IComidaRepositorio _comidaRepositorio;

        public DietaBusinessLogic(IPacienteRepositorio pacienteRepositorio, IComidaRepositorio comidaRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _comidaRepositorio = comidaRepositorio;
        }

        public string ElegirAlimentoAlAzar(int userid)
        {
            var paciente = _pacienteRepositorio.ObtenerPacientePorUsuarioId(userid);

            if (paciente == null)
            {
                return string.Empty;
            }

            var comidas = _comidaRepositorio.ComidasCompatiblesConAlergia(paciente.Alergias).ToList();
            var indice = new Random().Next(comidas.Count);
            return comidas[indice].Descripción;
        }
    }
}
