using System;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan tiempoPrimero = TimeSpan.FromHours(1);

            double velocidadPrimero = 80;
            double velocidadSegundo = 100;

            double distanciaRecorrida = velocidadPrimero * tiempoPrimero.TotalHours;
            double tiempoAlcance = distanciaRecorrida / (velocidadSegundo - velocidadPrimero);
        }
    }
}
