using System;
using System.Linq;
using System.Security.Principal;

namespace FitBuddy.WinForms.UI.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private CustomIdentity _identity;

        IIdentity IPrincipal.Identity => Identity;

        public bool IsInRole(string role) => _identity.Roles.Contains(role);

        public CustomIdentity Identity
        {
            get => _identity ?? new AnonymousIdentity();
            set => _identity = value;
        }
    }
}
