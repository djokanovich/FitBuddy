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
