using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clas10Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento MiEstacionamiento = new Estacionamiento(3, "Franco");

            Auto Auto1 = new Auto("IVM991");
            MiEstacionamiento.Agregar(Auto1);

            Auto Auto2 = new Auto("IVM991");
            MiEstacionamiento.Agregar(Auto2);

            Auto Auto3 = new Auto("IVM993");
            MiEstacionamiento.Agregar(Auto3);

            MiEstacionamiento.CompararPatente("IVM991");

            Console.ReadKey();
        }
    }
}
