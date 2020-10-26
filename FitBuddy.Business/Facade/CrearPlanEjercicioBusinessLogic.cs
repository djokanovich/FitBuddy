using FitBuddy.DataAccess.Repositorios;
using FitBuddy.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business.Facade
{
    public interface ICrearPlanEjercicioBusinessLogic
    {
        void GuardarPlanEjercicio(int userid, Paciente paciente);
    }

    
    public class CrearPlanEjercicioBusinessLogic : ICrearPlanEjercicioBusinessLogic
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public CrearPlanEjercicioBusinessLogic(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;

        }
        public void GuardarPlanEjercicio(int userid, Paciente paciente)
        {
            var pacienteEnDb = _pacienteRepositorio.ObtenerPacientePorUsuarioId(userid);

            if (pacienteEnDb == null)
            {
                _pacienteRepositorio.CrearPaciente(paciente);
            }
            else
            {
                pacienteEnDb.Antecedentes = paciente.Antecedentes;
                pacienteEnDb.DisposicionDiariaHoras = paciente.DisposicionDiariaHoras;
                pacienteEnDb.DisposicionSemanalDias = paciente.DisposicionSemanalDias;
                pacienteEnDb.FrecuenciaActual = paciente.FrecuenciaActual;
                pacienteEnDb.ObjetivoBuscado = paciente.ObjetivoBuscado;

                _pacienteRepositorio.ActualizarPaciente(pacienteEnDb.Id);
            }

            _pacienteRepositorio.GuardarCambios();
        }
    }
}
