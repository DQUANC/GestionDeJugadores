using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExamen_Dquan.Repositorio
{
    public class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public string InsertarNodo(string equipo, int noDeEquipo, string nombre, string apellido, double telefono)
        {
            Nodo nuevo = new Nodo();
            nuevo.Equipo = equipo;
            nuevo.NoDeJugador = noDeEquipo;
            nuevo.Nombre = nombre;
            nuevo.Apellido = apellido;
            nuevo.Telefono = telefono;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = primero;
                primero.Atras = ultimo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Atras = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Atras = ultimo;
            }
            return "Nuevo nodo Ingresado correctamente";
        }

        public string desplegarLista()
        {
            Nodo actual = new Nodo();
            string valorconcat = " ";
            actual = ultimo;
            if (actual != null)
            {
                do
                {

                    valorconcat = valorconcat + "\n Equipo del jugado: " + actual.Equipo +
                        "\n No. de jugador: " + actual.NoDeJugador +
                        "\n Nombre: " + actual.Nombre +
                        "\n Apellido: " + actual.Apellido +
                        "\n Telefono: " + actual.Telefono + "\n";
                    actual = actual.Atras;
                } while (actual != ultimo);
            }
            else
            {
                valorconcat = "La lista se encuentra vacia";
            }

            return valorconcat;
        }

        public void EliminarNodo(int eli)
        {
            Nodo actual = new Nodo();
            actual = primero;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            int nodoBuscado = eli;
            if (actual != null)
            {
                do
                {
                    if (actual.NoDeJugador == nodoBuscado)
                    {
                        if (actual == primero)
                        {
                            primero = primero.Siguiente;
                            primero.Atras = ultimo;
                            ultimo.Siguiente = primero;
                        }
                        else if (actual == ultimo)
                        {
                            ultimo = anterior;
                            ultimo.Siguiente = primero;
                            primero.Atras = ultimo;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                            actual.Siguiente.Atras = anterior;
                        }
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                } while (actual != primero && encontrado != true);
            }
        }

    }
}
