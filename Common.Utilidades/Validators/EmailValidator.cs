namespace Common.Utilidades.Validators
{
    public interface IEmailValidator
    {
        bool EsEmailVálido(string email);
    }

    public class EmailValidator : IEmailValidator
    {
        // Fuente: https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        public bool EsEmailVálido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
