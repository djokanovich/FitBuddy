using System.Security.Principal;

namespace FitBuddy.WinForms.UI.Security
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(int userId, string username, string[] roles)
        {
            UserId = userId;
            Name = username;
            Roles = roles;
        }

        public int UserId { get; set; }
        public string Name { get; private set; }
        public string Username { get => Name; set => Name = value; } // Alias, para que quede claro que Name es realmente Username
        public string[] Roles { get; private set; }

        public string AuthenticationType { get { return "Custom authentication"; } }

        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
    }
}
