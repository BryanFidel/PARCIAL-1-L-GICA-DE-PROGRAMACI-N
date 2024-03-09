using System;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double sueldoBase = 2000;
            const double porcentajeComision = 0.10;
            const double objetivoVentas = 1000000;
            const double beneficioExtra = 100000;

            double[] ventas = new double[3];
            double totalComisiones = 0;
            double totalVentas = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write("Ingrese el monto de la venta " + (i + 1) + ": ");
                ventas[i] = Convert.ToDouble(Console.ReadLine());
                totalVentas += ventas[i];
                totalComisiones += ventas[i] * porcentajeComision;
            }
            double totalMes = sueldoBase + totalComisiones;

            double mayorComision = 0;
            foreach (double venta in ventas)
            {
                double comisionVenta = venta * porcentajeComision;
                if (comisionVenta > mayorComision)
                {
                        mayorComision = comisionVenta;
                }
            }
            double promedioComisiones = totalComisiones / ventas.Length;

            bool superaObjetivo = totalVentas >= objetivoVentas;
            double totalConBeneficio = totalMes;
            if (superaObjetivo)
            {
                totalConBeneficio += beneficioExtra;
                Console.WriteLine("¡Felicidades! Has superado el objetivo y ganaste un beneficio extra de $" + beneficioExtra);
            }
            else
            {
                Console.WriteLine("No has superado el objetivo de ventas este mes.");

            }

            Console.WriteLine("Total por comisiones: $" + totalComisiones);
            Console.WriteLine("Total recibido en el mes: $" + totalMes);
            Console.WriteLine("La venta que generó la mayor comisión fue de: $" + mayorComision);
            Console.WriteLine("El promedio de las comisiones por venta fue de: $" + promedioComisiones);
            Console.WriteLine("El total recibido en el mes : $" + totalConBeneficio);

            Console.ReadLine();
        }
    }
}
