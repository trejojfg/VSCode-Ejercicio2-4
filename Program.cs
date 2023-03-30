using System;

namespace Ejercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
            // más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado 
            // y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            float totalFacturado, totalSueldo;
            const float sueldoFijo = 15000;
            const float comision = 0.05F;

            Console.WriteLine("Indique el total facturado:");
            totalFacturado = float.Parse(Console.ReadLine());
            totalSueldo = (comision * totalFacturado) + sueldoFijo;

            Console.WriteLine("El sueldo total es de " + totalSueldo);

        }
    }
}
