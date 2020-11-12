using FitBuddy.Business.Facade;
using FitBuddy.WinForms.UI.Animación;
using FitBuddy.WinForms.UI.Security;
using MetroFramework.Forms;
using System;
using System.Drawing;

namespace FitBuddy.WinForms.UI.Formularios
{
    public partial class Estadísticas : MetroForm
    {
        // Para la animación en este formulario usamos dos imágenes:
        // - El fondo de un velocímetro (ancho: 1024px, alto: 1272px)
        // - Una aguja (ancho: 2 * 660px, alto: 2 * 660px)
        // El punto de rotación en la imagen de fondo es en las coordenadas x = 512, y = 575.
        // La aguja está acostada, tiene un eje de simetría horizontal que pasa por y = 660, y apunta hacia la izquierda.
        // El punto de rotación de la aguja está en x = 660 sobre el eje de simetría.
        // Para que la aguja quede en la posición correcta sobre el fondo, hay que achicarla a 765px x 765px,
        // y posicionar la esquina superior izquierda en las coordenadas x = 133, y = 201.

        private const int ImagenVelocímetroAncho = 1024;
        private const int ImagenVelocímetroAlto = 1272;

        private const int ImagenAgujaEsquinaIzquierda = 133;
        private const int ImagenAgujaEsquinaSuperior = 201;
        private const int ImagenAgujaAncho = 765;
        private const int ImagenAgujaAlto = 765;

        private PointF PuntoDeRotaciónDeImagenAguja => new PointF(660, 660);

        private readonly Bitmap _imagenAguja;

        private readonly IFormManager _formManager;
        private readonly IEstadísticasBusinessLogic _estadisticasBusinessLogic;
        private readonly Animar _animar;

        public Estadísticas(IFormManager formManager, IEstadísticasBusinessLogic estadisticasBusinessLogic, Animar animar)
        {
            InitializeComponent();

            lblWelcome.Text = $"{IdentityManager.UsuarioActual.Username}";

            _formManager = formManager;
            _estadisticasBusinessLogic = estadisticasBusinessLogic;
            _animar = animar;

            _imagenAguja = new Bitmap(Properties.Resources.Aguja);
            ConfigurarImágenes(anchoVelocímetroDeseado: 220);

            _animar.SeleccionarFunciónAlAzar();
            _animar.EjecutarACadaInstanteDeTiempo += EjecutarACadaInstanteDeTiempo;
            _animar.IniciarCronómetro();
        }

        private void ConfigurarImágenes(int anchoVelocímetroDeseado)
        {
            // Asignar a cada PictureBox su imagen correspondiente.
            picFondo.Image = new Bitmap(Properties.Resources.Velocimetro);
            picAguja.Image = _imagenAguja;

            // Dimensionar la imagen de fondo del velocímetro.
            picFondo.Width = anchoVelocímetroDeseado;
            picFondo.Height = ImagenVelocímetroAlto * picFondo.Width / ImagenVelocímetroAncho;

            // Ubicar la aguja dentro del velocímetro.
            picFondo.Controls.Add(picAguja);

            // Ubicar la aguja en referencia al fondo, considerando el tamaño en la pantalla del fondo.
            picAguja.Location = new Point(ImagenAgujaEsquinaIzquierda * picFondo.Width / ImagenVelocímetroAncho,
                ImagenAgujaEsquinaSuperior * picFondo.Height / ImagenVelocímetroAlto);

            // Dimensionar la imagen de la aguja.
            picAguja.Width = ImagenAgujaAncho * picFondo.Width / ImagenVelocímetroAncho;
            picAguja.Height = ImagenAgujaAlto * picFondo.Height / ImagenVelocímetroAlto;

            // Fundamental para que se vea lindo: la aguja debe tener fondo transparente para que se vea el velocímetro.
            picAguja.BackColor = Color.Transparent;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            var usuarioId = IdentityManager.UsuarioActual.UserId;
            _estadisticasBusinessLogic.CalcularEstadísticasDePacientePorUsuarioId(usuarioId);

            lblImc.Text = _estadisticasBusinessLogic.Imc.ToString("N2");
            lblIgc.Text = _estadisticasBusinessLogic.Igc.ToString("N2");

            lblImcClasificación.Text = _estadisticasBusinessLogic.ImcClasificación;
            lblIgcClasificacion.Text = _estadisticasBusinessLogic.IgcClasificación;
        }

        private void EjecutarACadaInstanteDeTiempo(object sender, EventArgs e)
        {
            const float imcMáximo = 30;

            var ánguloFinal = _estadisticasBusinessLogic.Imc > imcMáximo ? 180.0f : 180 * (float)_estadisticasBusinessLogic.Imc / imcMáximo;
            var ánguloARotar = ánguloFinal * _animar.SiguienteValor();
            picAguja.Image = Transformación.RotarImagen(_imagenAguja, PuntoDeRotaciónDeImagenAguja, ánguloARotar);

            if (_animar.AnimaciónFinalizada) _animar.PararCronómetro();
        }

        protected override void OnClosed(EventArgs e)
        {
            _animar.PararCronómetro();
            base.OnClosed(e);
        }

        private void OnBtnCerrarClick(object sender, EventArgs e)
        {
            _animar.PararCronómetro();
            _formManager.Close(this);
        }

        private void picAguja_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager formManager = _formManager.Show<EstadisticasCompletas>();
        }
    }
}
