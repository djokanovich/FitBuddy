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
    public interface IFormManager
    {
        IContainer Container { get; set; }
        FormManager Show<F>() where F : Form;
        FormManager AndClose(Form form);
        void Close(Form form);
    }

    public class FormManager : IFormManager
    {
        private readonly IBitacora<FormManager> _bitacora;

        public FormManager(IBitacora<FormManager> bitacora)
        {
            _bitacora = bitacora;
        }

        public IContainer Container { get; set; }

        public FormManager Show<F>() where F : Form
        {
            _bitacora.Debug($"Abriendo el formulario de {typeof(F).Name}");
            var form = Container.Resolve<F>();
            form.Show();

            return this;
        }

        public FormManager AndClose(Form form)
        {
            Close(form);
            return this;
        }

        public void Close(Form form)
        {
            form.Close();
        }
    }
}
