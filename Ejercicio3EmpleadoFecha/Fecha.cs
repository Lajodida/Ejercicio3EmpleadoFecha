using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3EmpleadoFecha
{
    public class Fecha
    {
        private int _intAnio;
        private int _intDia;
        private int _intMes;
        public Fecha(int dia,int mes,int anio)
        {
           Anio=anio;
           Mes=mes;
           Dia=dia;
        }
        public int Anio
        {
            get { return _intAnio; }
            set { _intAnio = value; }
        }

        public int Dia
        {
            get { return _intDia; }
            set
            {
                int maxDias = 31;

                if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
                {
                    maxDias = 30;
                }
                else if (Mes == 2)
                {
                    if ((Anio % 4 == 0 && Anio % 100 != 0) || Anio % 400 == 0)
                    {
                        maxDias = 29;
                    }
                    else
                    {
                        maxDias = 28;
                    }
                }

                if (value > 0 && value <= maxDias)
                {
                    _intDia = value;
                }
                else
                {
                    Console.WriteLine("Dia", "El día ingresado es inválido para el mes y año especificados.");
                }
            }
        }

        public int Mes
        {
            get { return _intMes; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    _intMes = value;
                }
                else
                {
                    Console.WriteLine("El mes debe estar entre 1 y 12");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}",Dia,Mes,Anio);           
        }


    }
}