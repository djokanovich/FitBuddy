using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.DataAccess.Util
{
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
