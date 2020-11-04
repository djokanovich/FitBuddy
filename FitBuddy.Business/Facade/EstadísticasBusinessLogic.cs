using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using System;
using System.Linq;

namespace FitBuddy.Business.Facade
{
    public interface IEstadísticasBusinessLogic
    {
        double Imc { get; set; }
        double Igc { get; set; }
        string ImcClasificación { get; set; }
        string IgcClasificación { get; set; }

        void CalcularEstadísticasDePacientePorUsuarioId(int userId);
    }

    public class EstadísticasBusinessLogic : IEstadísticasBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public EstadísticasBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public double Imc { get; set; }
        public double Igc { get; set; }
        public string ImcClasificación { get; set; }
        public string IgcClasificación { get; set; }

        public void CalcularEstadísticasDePacientePorUsuarioId(int usuarioId)
        {
            var paciente = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (paciente == null || paciente.HistorialPaciente == null || !paciente.HistorialPaciente.Any())
                return;

            var últimoRegistroDelPaciente = paciente.ÚltimoRegistro();
            var alturaEnMetros = últimoRegistroDelPaciente.AlturaEnCm / 100.0;
            
            CalcularImc(últimoRegistroDelPaciente.PesoEnKg, alturaEnMetros);
            CalcularIgc(paciente.Edad, paciente.Género);
            ClasificarPorImc();
            ClasificarPorIgc(paciente.Edad, paciente.Género);
        }

        private void CalcularImc(double pesoEnKg, double alturaEnMetros)
        {
            Imc = pesoEnKg / Math.Pow(alturaEnMetros, 2);
        }

        private void CalcularIgc(int edad, Género género)
        {
            // Fórmula de Deurenberg
            // Para una mujer: IMG = (1,2 × IMC) + (0,23 × edad) - 5,4
            // Para un hombre: IMG = (1,2 × IMC) + (0,23 × edad) - 16,2

            var offset = género == Género.Femenino ? 5.4 : 16.2; // Operador condicional ternario

            Igc = (1.2 * Imc) + (0.23 * edad) - offset;
        }

        private void ClasificarPorImc()
        {
            switch (Imc)
            {
                case var imc when imc <= 18.5:
                    ImcClasificación = "Por debajo del peso apropiado.";
                    break;

                case var imc when imc <= 25.0:
                    ImcClasificación = "Dentro de los rangos normales.";
                    break;

                case var imc when imc <= 30.0:
                    ImcClasificación = "Con sobrepeso.";
                    break;

                default:
                    ImcClasificación = "Obeso.";
                    break;
            }
        }

        private void ClasificarPorIgc(int edad, Género género)
        {
            if (género == Género.Femenino)
            {
                switch (Igc)
                {
                    //Atleta
                    case var igc when igc <= 11.0 && edad <= 29:
                        IgcClasificación = "Atleta";
                        break;

                    case var igc when igc <= 12.0 && edad <= 39:
                        IgcClasificación = "Atleta";
                        break;

                    case var igc when igc <= 14.0 && edad <= 49:
                        IgcClasificación = "Atleta";
                        break;

                    case var igc when igc <= 15.0:
                        IgcClasificación = "Atleta";
                        break;

                    //Bueno
                    case var igc when igc <= 13.0 && edad <= 29:
                        IgcClasificación = "Bueno";
                        break;

                    case var igc when igc <= 14.0 && edad <= 39:
                        IgcClasificación = "Bueno";
                        break;

                    case var igc when igc <= 16.0 && edad <= 49:
                        IgcClasificación = "Bueno";
                        break;

                    case var igc when igc <= 17.0:
                        IgcClasificación = "Bueno";
                        break;

                    //Normal
                    case var igc when igc <= 20.0 && edad <= 29:
                        IgcClasificación = "Normal";
                        break;

                    case var igc when igc <= 21.0 && edad <= 39:
                        IgcClasificación = "Normal";
                        break;

                    case var igc when igc <= 23.0 && edad <= 49:
                        IgcClasificación = "Normal";
                        break;

                    case var igc when igc <= 24.0:
                        IgcClasificación = "Normal";
                        break;

                    //Elevado
                    case var igc when igc <= 23.0 && edad <= 29:
                        IgcClasificación = "Elevado";
                        break;

                    case var igc when igc <= 24.0 && edad <= 39:
                        IgcClasificación = "Elevado";
                        break;

                    case var igc when igc <= 26.0 && edad <= 49:
                        IgcClasificación = "Elevado";
                        break;

                    case var igc when igc <= 27.0:
                        IgcClasificación = "Elevado";
                        break;


                    //Muy elevado
                    case var igc when igc > 23.0 && edad <= 29:
                        IgcClasificación = "Muy elevado";
                        break;

                    case var igc when igc > 24.0 && edad <= 39:
                        IgcClasificación = "Muy elevado";
                        break;

                    case var igc when igc > 26.0 && edad <= 49:
                        IgcClasificación = "Muy elevado";
                        break;

                    case var igc when igc > 27.0:
                        IgcClasificación = "Muy elevado";
                        break;

                    default:
                        IgcClasificación = "{Indeterminado}";
                        break;
                }
            }
            else // Género = Masculino
            {
                // TODO
            }
        }
    }
}
