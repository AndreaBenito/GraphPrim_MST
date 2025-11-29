using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Vertices
    {
        public string dato { get; set; }

        public List<(Vertices vertice, int peso)> Adyacentes { get; set; }

        public List<Vertices> Indices { get; set; }

        public Vertices(string dato)
        {
            this.dato = dato;
            Adyacentes = new List<(Vertices, int)>();
            Indices = new List<Vertices>();
        }
    }
}
