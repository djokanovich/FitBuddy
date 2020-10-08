using Autofac;
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
        public IContainer Container { get; set; }

        public void Show<F>() where F : Form
        {
            var form = Container.Resolve<F>();
            form.Show();
        }
    }
}
