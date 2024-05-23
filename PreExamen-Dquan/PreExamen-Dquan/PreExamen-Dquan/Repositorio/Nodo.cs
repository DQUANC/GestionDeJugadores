using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen_Dquan.Repositorio
{
    public class Nodo
    {
        private string equipo;
        private int noDeJugador;
        private string nombre;
        private string apellido;
        private double telefono;
        private Nodo siguiente;
        private Nodo atras;

        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        public int NoDeJugador
        {
            get { return noDeJugador; }
            set { noDeJugador = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public double Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
}
