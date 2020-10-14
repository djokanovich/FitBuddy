using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Security;
using System;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Estadísticas : Form
    {
        private readonly IEstadisticasBusinessLogic _estadisticasBusinessLogic;



        public Estadísticas(IEstadisticasBusinessLogic estadisticasBusinessLogic)
        {
            InitializeComponent();
            lblWelcome.Text = $"{IdentityManager.UsuarioActual.Username}";
            _estadisticasBusinessLogic = estadisticasBusinessLogic;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            (lblImc.Text, lblIgc.Text) = _estadisticasBusinessLogic.CalcularIndices(IdentityManager.UsuarioActual.UserId);
            switch (double.Parse(lblImc.Text))
            {
                case var imc when imc <= 18.5:
                    lblImcClasificación.Text = "Por debajo del peso apropiado.";
                    break;
                
                case var imc when imc <= 25.0:
                    lblImcClasificación.Text = "Dentro de los rangos normales.";
                    break;

                case var imc when imc <= 30.0:
                    lblImcClasificación.Text = "Con sobrepeso.";
                    break;

                default:
                    lblImcClasificación.Text = "Obeso.";
                    break;
            }

            (var edad, var genero) = _estadisticasBusinessLogic.ObtenerEdadyGeneroPorUsuarioId(IdentityManager.UsuarioActual.UserId);
            if (genero == Entidades.Genero.Femenino)
            {
                switch (double.Parse(lblIgc.Text))
                {
                    //Atleta
                    case var igc when igc <= 11.0 && edad <= 29:
                        lblClasificacionIGC.Text = "Atleta";
                        break;

                    case var igc when igc <= 12.0 && edad <= 39:
                        lblClasificacionIGC.Text = "Atleta";
                        break;

                    case var igc when igc <= 14.0 && edad <= 49:
                        lblClasificacionIGC.Text = "Atleta";
                        break;

                    case var igc when igc <= 15.0:
                        lblClasificacionIGC.Text = "Atleta";
                        break;


                    //Bueno
                    case var igc when igc <= 13.0 && edad <= 29:
                        lblClasificacionIGC.Text = "Bueno";
                        break;

                    case var igc when igc <= 14.0 && edad <= 39:
                        lblClasificacionIGC.Text = "Bueno";
                        break;

                    case var igc when igc <= 16.0 && edad <= 49:
                        lblClasificacionIGC.Text = "Bueno";
                        break;

                    case var igc when igc <= 17.0:
                        lblClasificacionIGC.Text = "Bueno";
                        break;

                    //Normal
                    case var igc when igc <= 20.0 && edad <= 29:
                        lblClasificacionIGC.Text = "Normal";
                        break;

                    case var igc when igc <= 21.0 && edad <= 39:
                        lblClasificacionIGC.Text = "Normal";
                        break;

                    case var igc when igc <= 23.0 && edad <= 49:
                        lblClasificacionIGC.Text = "Normal";
                        break;

                    case var igc when igc <= 24.0:
                        lblClasificacionIGC.Text = "Normal";
                        break;

                    //Elevado
                    case var igc when igc <= 23.0 && edad <= 29:
                        lblClasificacionIGC.Text = "Elevado";
                        break;

                    case var igc when igc <= 24.0 && edad <= 39:
                        lblClasificacionIGC.Text = "Elevado";
                        break;

                    case var igc when igc <= 26.0 && edad <= 49:
                        lblClasificacionIGC.Text = "Elevado";
                        break;

                    case var igc when igc <= 27.0:
                        lblClasificacionIGC.Text = "Elevado";
                        break;


                    //Muy elevado
                    case var igc when igc > 23.0 && edad <= 29:
                        lblClasificacionIGC.Text = "Muy elevado";
                        break;

                    case var igc when igc > 24.0 && edad <= 39:
                        lblClasificacionIGC.Text = "Muy elevado";
                        break;

                    case var igc when igc > 26.0 && edad <= 49:
                        lblClasificacionIGC.Text = "Muy elevado";
                        break;

                    case var igc when igc > 27.0:
                        lblClasificacionIGC.Text = "Muy elevado";
                        break;



                }

            }
            else
            {
                
            }
            

        }
    }
}
