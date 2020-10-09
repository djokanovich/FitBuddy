using System.Linq;

namespace FitBuddy.DataAccess.Util
{
    // TODO: Eliminar esta clase y usar un hash (p.ej. MD5, que ya está implementado en el proyecto Common.Utilidades)
    public class CodigoDeControl
    {
        public static int Luhn(byte[] input) 
        {
            // Multiplicar elemento por medio por dos.
            for (int i = input.Length - 1; i >= 0; i -= 2)
            {
                input[i] = (byte)(input[i] * 2 % 256);
            }

            // TODO: En verdad esto debería ser la suma de los dígitos.
            var suma = input.Select(i => (int)i).Sum();
            
            return 10 - (suma % 10);
        }
    }
}
