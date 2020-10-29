using System;

namespace Common.Utilidades
{
    public class RandomNumberGeneratorService
    {
        private readonly Random _random;

        public RandomNumberGeneratorService()
        {
            _random = new Random();
        }

        public int NúmeroAlAzar(int máximo)
        {
            return _random.Next(máximo);
        }

        public int NúmeroAlAzar(int mínimo, int máximo)
        {
            return _random.Next(mínimo, máximo);
        }
    }
}
