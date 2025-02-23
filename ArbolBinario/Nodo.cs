using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOL_3
{
    class Nodo
    {
        public string Nombre { get; set; }

        public Nodo Derecha { get; set; }

        public Nodo Izquierda { get; set; }


        public Nodo (string nombre)
       
        { 
            Nombre = nombre; 
        
        }

    }
}
