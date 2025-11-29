using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    internal class Grafo
    {
        public List<Vertices> VERTICES { get; set; }
        int[,] mAd;

        int[,] PrimMatriz;

        public List<(string origen, string destino, int peso)> PrimEdges { get; set; }

        public Grafo()
        {
            VERTICES = new List<Vertices>();
            PrimEdges = new List<(string origen, string destino, int peso)>();
        }

        public void AgregarVertice(string dato)
        {
            VERTICES.Add(new Vertices(dato));
            ActualizarMatriz();
        }

        public void AgregarAristas(string origen, string destino, int peso = 1)
        {
            Vertices vOrigen = VERTICES.Find(v => v.dato == origen);
            Vertices vDestino = VERTICES.Find(v => v.dato == destino);

            if (vOrigen != null && vDestino != null)
            {
                vOrigen.Adyacentes.Add((vDestino, peso));
                vDestino.Adyacentes.Add((vOrigen, peso));
                ActualizarMatriz();
            }
        }

        public void ActualizarMatriz()
        {
            int n = VERTICES.Count;
            mAd = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mAd[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Vertices verticeActual = VERTICES[i];
                foreach (var (adyacente, peso) in verticeActual.Adyacentes)
                {
                    int j = VERTICES.FindIndex(v => v.dato == adyacente.dato);
                    if (j != -1)
                    {
                        mAd[i, j] = peso;
                    }
                }
            }
        }

        public void MostrarMatrizAdyacencia(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            foreach (var vertice in VERTICES)
            {
                dgv.Columns.Add(vertice.dato, vertice.dato);
            }

            for (int i = 0; i < VERTICES.Count; i++)
            {
                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].HeaderCell.Value = VERTICES[i].dato;


                for (int j = 0; j < VERTICES.Count; j++)
                {
                    dgv.Rows[rowIndex].Cells[j].Value = mAd[i, j];
                }
            }
        }

        public void MostrarListaAdyacencia(DataGridView dgv)
        {
            dgv.Rows.Clear();

            foreach (var vertice in VERTICES)
            {
                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells[0].Value = vertice.dato;

                string adyacentes = string.Join(", ", vertice.Adyacentes.Select(a => a.vertice.dato));
                dgv.Rows[rowIndex].Cells[1].Value = adyacentes;
            }
        }


        public void Prim()
        {
            PrimEdges.Clear();

            if (VERTICES.Count == 0) return;

            var visitados = new HashSet<Vertices>();
            var aristasMinimas = new List<(Vertices origen, Vertices destino, int peso)>();

            int n = VERTICES.Count;
            PrimMatriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    PrimMatriz[i, j] = 0;
                }
            }


            visitados.Add(VERTICES[0]);

            while (visitados.Count < VERTICES.Count)
            {
                (Vertices mejorOrigen, Vertices mejorDestino, int mejorPeso) = (null, null, int.MaxValue);


                foreach (var verticeVisitado in visitados)
                {
                    foreach (var (adyacente, peso) in verticeVisitado.Adyacentes)
                    {
                        if (!visitados.Contains(adyacente) && peso < mejorPeso)
                        {
                            mejorPeso = peso;
                            mejorOrigen = verticeVisitado;
                            mejorDestino = adyacente;
                        }
                    }
                }

                if (mejorDestino != null)
                {
                    aristasMinimas.Add((mejorOrigen, mejorDestino, mejorPeso));
                    visitados.Add(mejorDestino);

                    int idxOrigen = VERTICES.IndexOf(mejorOrigen);
                    int idxDestino = VERTICES.IndexOf(mejorDestino);
                    PrimMatriz[idxOrigen, idxDestino] = mejorPeso;
                    PrimMatriz[idxDestino, idxOrigen] = mejorPeso;

                    PrimEdges.Add((mejorOrigen.dato, mejorDestino.dato, mejorPeso));

                }
                else
                {
                    break;
                }
            }

        }

        public void MostrarMatrizPrim(DataGridView dgv)
        {
            if (PrimMatriz == null)
            {
                MessageBox.Show("Ejecutar primero el algoritmo de Prim");
                return;
            }

            dgv.Rows.Clear();
            dgv.Columns.Clear();

            foreach (var vertice in VERTICES)
            {
                dgv.Columns.Add(vertice.dato, vertice.dato);
            }

            int pesoTotal = 0;
            int aristasEncontradas = 0;

            for (int i = 0; i < VERTICES.Count; i++)
            {
                int rowIndex = dgv.Rows.Add();
                dgv.Rows[rowIndex].HeaderCell.Value = VERTICES[i].dato;

                for (int j = 0; j < VERTICES.Count; j++)
                {
                    dgv.Rows[rowIndex].Cells[j].Value = PrimMatriz[i, j];

                    if (PrimMatriz[i, j] > 0 && i < j)
                    {
                        pesoTotal += PrimMatriz[i, j];
                        aristasEncontradas++;
                    }
                }
            }


            string mensaje = $"Árbol de Expansión Mínima Encontrado:\n\n";
            mensaje += $"• Vértices: {VERTICES.Count}\n";
            mensaje += $"• Aristas en el árbol: {aristasEncontradas}\n";
            mensaje += $"• Peso total: {pesoTotal}\n\n";
            mensaje += "La matriz del árbol se muestra en la tabla.";

            MessageBox.Show(mensaje, "Resultado del Algoritmo de Prim",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}