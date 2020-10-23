using System;

namespace FitBuddy.WinForms.UI.Animación
{
    /// <summary>
    /// Colección de funciones de suavizado.
    /// Todas las funciones toman valores en 0 y 1.
    /// </summary>
    public static class FuncionesDeSuavizado
    {
        public static float InOutCubic(float x)
        {
            return x < 0.5 ? 4 * x * x * x : 1 - (float)Math.Pow(-2 * x + 2, 3) / 2;
        }

        public static float InOutBack(float x)
        {
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;

            return x < 0.5
              ? (float)((Math.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2)
              : (float)((Math.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2);
        }

        public static float OutBack(float x)
        {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1;

            return 1 + (float)(c3 * Math.Pow(x - 1, 3) + c1 * Math.Pow(x - 1, 2));
        }

        public static float OutBounce(float x)
        {
            const float n1 = 7.5625f;
            const float d1 = 2.75f;

            if (x < 1 / d1)
            {
                return n1 * x * x;
            }
            else if (x < 2 / d1)
            {
                return n1 * (x -= 1.5f / d1) * x + 0.75f;
            }
            else if (x < 2.5 / d1)
            {
                return n1 * (x -= 2.25f / d1) * x + 0.9375f;
            }
            else
            {
                return n1 * (x -= 2.625f / d1) * x + 0.984375f;
            }
        }

        public static float InOutBounce(float x)
        {
            return x < 0.5
              ? (1 - OutBounce(1 - 2 * x)) / 2
              : (1 + OutBounce(2 * x - 1)) / 2;
        }

        public static float InElastic(float x)
        {
            const float c4 = (2 * (float)Math.PI) / 3;

            if (x == 0) return 0;
            if (x == 1) return 1;

            return (float)(-Math.Pow(2, 10 * x - 10) * Math.Sin((x * 10 - 10.75) * c4));
        }

        public static float OutElastic(float x)
        {
            const double c4 = (2 * Math.PI) / 3;

            if (x == 0) return 0;
            if (x == 1) return 1;

            return (float)(Math.Pow(2, -10 * x) * Math.Sin((10 * x - 0.75) * c4) + 1);
        }

        public static float InOutElastic(float x)
        {
            const float c5 = (2 * (float)Math.PI) / 4.5f;

            if (x == 0) return 0;
            if (x == 1) return 1;

            return x < 0.5
              ? (float)(-(Math.Pow(2, 20 * x - 10) * Math.Sin((20 * x - 11.125) * c5)) / 2)
              : (float)((Math.Pow(2, -20 * x + 10) * Math.Sin((20 * x - 11.125) * c5)) / 2 + 1);
        }
    }
}
