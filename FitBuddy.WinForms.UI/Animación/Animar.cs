using System;
using System.Windows.Forms;
using Common.Utilidades;

namespace FitBuddy.WinForms.UI.Animación
{
    public class Animar
    {
        public delegate float FunciónDeSuavizado(float x);

        private readonly FunciónDeSuavizado[] _funcionesDeSuavizados = new FunciónDeSuavizado[]
        {
            FuncionesDeSuavizado.InOutCubic,
            FuncionesDeSuavizado.InOutBack,
            FuncionesDeSuavizado.OutBack,
            FuncionesDeSuavizado.OutBounce,
            FuncionesDeSuavizado.InOutBounce,
            FuncionesDeSuavizado.InElastic,
            FuncionesDeSuavizado.OutElastic,
            FuncionesDeSuavizado.InOutElastic
        };

        private FunciónDeSuavizado _función;

        private readonly Timer _timer = new Timer();
        private readonly RandomNumberGeneratorService _rngService;
        private float _instanteDeTiempo = 0;

        public Animar(RandomNumberGeneratorService rngService)
        {
            _timer.Interval = 10;
            _rngService = rngService;
        }

        public EventHandler EjecutarACadaInstanteDeTiempo { get; set; }

        public bool AnimaciónFinalizada => _instanteDeTiempo > 1;

        public void IniciarCronómetro()
        {
            _timer.Start();
            _timer.Tick += EjecutarACadaInstanteDeTiempo;
        }

        public void PararCronómetro()
        {
            _timer.Stop();
        }

        public void SeleccionarFunciónAlAzar()
        {
            var randomIndex = _rngService.NúmeroAlAzar(_funcionesDeSuavizados.Length);
            _función = _funcionesDeSuavizados[randomIndex];
        }

        public void Seleccionar(FunciónDeSuavizado función)
        {
            var index = Array.IndexOf(_funcionesDeSuavizados, función);
            _función = _funcionesDeSuavizados[index];
        }

        public float SiguienteValor()
        {
            var valor = _función(_instanteDeTiempo);
            _instanteDeTiempo += .01f;

            return valor;
        }

        public void Reiniciar()
        {
            _instanteDeTiempo = 0;
        }
    }
}
