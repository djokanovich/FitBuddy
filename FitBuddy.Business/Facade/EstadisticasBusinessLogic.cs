using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using System;
using System.Linq;

namespace FitBuddy.Business.Facade
{
    public interface IEstadisticasBusinessLogic
    {
        double Imc { get; set; }
        string ImcString { get; set; }
        string IgcString { get; set; }
        string ImcClasificación { get; set; }
        string IgcClasificación { get; set; }

        void CalcularEstadísticasDePacientePorUsuarioId(int userId);
    }

    public class EstadisticasBusinessLogic : IEstadisticasBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        private Paciente _paciente;
        private double _igc;

        public EstadisticasBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public double Imc { get; set; }
        public string ImcString { get; set; }
        public string IgcString { get; set; }
        public string ImcClasificación { get; set; }
        public string IgcClasificación { get; set; }

        public void CalcularEstadísticasDePacientePorUsuarioId(int usuarioId)
        {
            _paciente = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (_paciente != null)
            {
                CalcularImc();
                CalcularIgc();
                ClasificarPorImc();
                ClasificarPorIgc();
            }
        }

        private void CalcularImc()
        {
            var peso = _paciente.Peso;
            var altura = _paciente.Altura / 100.0; // Expresada en metros.

            Imc = peso / Math.Pow(altura, 2);


            ImcString = Imc.ToString("N2");
        }

        private void CalcularIgc()
        {
            // Fórmula de Deurenberg
            // Para una mujer: IMG = (1,2 × IMC) + (0,23 × edad) - 5,4
            // Para un hombre: IMG = (1,2 × IMC) + (0,23 × edad) - 16,2

            var edad = _paciente.Edad;
            var offset = _paciente.Genero == Genero.Femenino ? 5.4 : 16.2; // Operador condicional ternario

            _igc = (1.2 * Imc) + (0.23 * edad) - offset;

            IgcString = _igc.ToString("N2");
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

        private void ClasificarPorIgc()
        {
            var edad = _paciente.Edad;
            if (_paciente.Genero == Genero.Femenino)
            {
                switch (_igc)
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
