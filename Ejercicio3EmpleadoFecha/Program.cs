using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3EmpleadoFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Fecha fechaNacimiento = new Fecha(4, 6, 2001);
            Fecha fechaContratacion = new Fecha(20, 10, 2022);
           
            Empleado empleadito= new Empleado("Díaz","Horacio", fechaNacimiento, fechaContratacion);

            Console.WriteLine(empleadito.ToString()) ;

            Console.ReadLine();
        }
    }
}
