using System;

namespace DeviceEmulation.Infrastructure
{
   internal static class RandomValue
    {

        internal static int GetRandom(int min,int max)
        {
            var rundom = new Random();

            return rundom.Next(min, max);
        }
    }
}
