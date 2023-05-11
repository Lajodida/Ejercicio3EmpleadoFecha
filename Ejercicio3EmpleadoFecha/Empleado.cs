using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3EmpleadoFecha
{
    public class Empleado
    {
        private string _strApellido;
        private string _strPrimerNombre;
        private Fecha FechaContratacion;
        private Fecha FechaNacimiento;

        public string Apellido
        {
            get { return _strApellido; }
            set { _strApellido = value; }
        }
        public string PrimerNombre
        {
            get { return _strPrimerNombre; }
            set { _strPrimerNombre = value; }
        }

        public Empleado(string apellido,string nombre,Fecha fechanac,Fecha fechacon)
        {
            Apellido=apellido;
            PrimerNombre=nombre;
            FechaNacimiento = fechanac;
            FechaContratacion = fechacon;
            
        }
       
        public override string ToString()
        {
            return string.Format("Apellido y nombre: {0}, {1}. Fecha de nacimiento: {2" +
                "} y fecha de contratación {3}.",Apellido,PrimerNombre,FechaNacimiento,FechaContratacion);
        }
    }
}