using Autofac;
using Common.Bitacora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.Formularios
{
    public interface IFormBuilder
    {
        IContainer Container { get; set; }

        void Show<F>() where F : Form;
    }

    public class FormBuilder : IFormBuilder
    {
        private readonly IBitacora _bitacora;

        public FormBuilder(IBitacora bitacora)
        {
            _bitacora = bitacora;
        }

        public IContainer Container { get; set; }

        public void Show<F>() where F : Form
        {
            _bitacora.Debug($"Solicitud de mostrar el formulario de ${typeof(F).Name}");
            var form = Container.Resolve<F>();
            form.Show();
        }
    }
}
