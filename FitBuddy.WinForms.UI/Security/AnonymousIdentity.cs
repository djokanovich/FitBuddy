using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.WinForms.UI.Security
{
    public class AnonymousIdentity : CustomIdentity
    {
        public AnonymousIdentity()
            : base(0, string.Empty, new string[] { })
        {
        }
    }
}
