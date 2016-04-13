using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clas10Ejercicio10
{
    class Estacionamiento
    {
        public string nombre;
        public List<Auto> ListaDeAutos;
        public int CantidadDeCocheras;

        public Stack<Auto> PilaDeAutos;
        public Queue<Auto> ColaDeAutos;

        public Estacionamiento(int CantiCocheras, string Nombre)
        {
            this.CantidadDeCocheras = CantiCocheras;
            this.nombre = Nombre;
            this.ListaDeAutos = new List<Auto>();

            this.ColaDeAutos=new Queue<Auto>();
            this.PilaDeAutos=new Stack<Auto>();
        }

        public void Agregar(Auto UnAuto)
        {
            this.ListaDeAutos.Add(UnAuto);
            this.PilaDeAutos.Pop();
            this.ColaDeAutos.Enqueue(UnAuto);
        }

        public bool CompararPatente(string Patente)
        {
            bool respuesta=false;

            foreach (Auto Autorrecorriendo in ListaDeAutos)
            {
                if (Autorrecorriendo.patente == Patente)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator ==(Estacionamiento UnEstacionamiento, Auto UnAuto)
        {
            bool respuesta = false;

            foreach (Auto Autorrecorriendo in UnEstacionamiento.ListaDeAutos)
            {
                if (Autorrecorriendo.patente == UnAuto.patente)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Estacionamiento UnEstacionamiento, Auto UnAuto)
        {
            return !(UnEstacionamiento == UnAuto);
        }


    }
}
