using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Grafo grafo1 = new Grafo();

        private List<VisualVertex> visualVertices = new List<VisualVertex>();
        private List<VisualEdge> visualEdges = new List<VisualEdge>();
        private bool grafoCreado = false;

        public Form1()
        {
            InitializeComponent();
            panelCanvas.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMostrarGrafo.Enabled = false;
            btnAplicarPrim.Enabled = false;
        }

        private void btnCrearNodo_Click(object sender, EventArgs e)
        {
            string Dato = txtNodo.Text;

            if (!string.IsNullOrEmpty(Dato))
            {
                if (grafo1.VERTICES.Any(v => v.dato == Dato))
                {
                    MessageBox.Show("Ya existe un vértice con ese nombre");
                    return;
                }

                grafo1.AgregarVertice(Dato);
                txtNodo.Clear();

                grafo1.MostrarListaAdyacencia(dgvNodos);
                grafo1.MostrarMatrizAdyacencia(dgvMatriz);

                btnMostrarGrafo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un dato válido para el vértice.");
            }
        }

        private void btnCrearAristaDirigida_Click(object sender, EventArgs e)
        {
            string Origen = txtOrigen.Text;
            string Destino = txtDestino.Text;
            int peso = string.IsNullOrEmpty(txtPeso.Text) ? 1 : int.Parse(txtPeso.Text);

            if (!string.IsNullOrEmpty(Origen) && !string.IsNullOrEmpty(Destino))
            {
                if (!grafo1.VERTICES.Any(v => v.dato == Origen) || !grafo1.VERTICES.Any(v => v.dato == Destino))
                {
                    MessageBox.Show("Uno o ambos vértices no existen en el grafo.");
                    return;
                }
                grafo1.AgregarAristas(Origen, Destino, peso);
                MessageBox.Show("Arista creada exitosamente.");

                txtOrigen.Clear();
                txtDestino.Clear();
                txtPeso.Clear();
                grafo1.MostrarListaAdyacencia(dgvNodos);
                grafo1.MostrarMatrizAdyacencia(dgvMatriz);

                btnMostrarGrafo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos para el origen y destino de la arista.");
            }
        }
        private void btnAplicarPrim_Click(object sender, EventArgs e)
        {
            if (!grafoCreado)
            {
                MessageBox.Show("Primero debe crear y visualizar el grafo.");
                return;
            }

            grafo1.Prim();
            grafo1.MostrarMatrizPrim(dgvPrim);

            foreach (var edge in visualEdges)
            {
                edge.IsMST = false;
                edge.Color = Color.Black;
            }

            foreach (var ar in grafo1.PrimEdges)
            {
                var match = visualEdges.FirstOrDefault(ve =>
                    (ve.A.Nombre == ar.origen && ve.B.Nombre == ar.destino) ||
                    (ve.A.Nombre == ar.destino && ve.B.Nombre == ar.origen));

                if (match != null)
                {
                    match.IsMST = true;
                    match.Color = Color.Green;
                }

            }

            panelCanvas.Invalidate();

            MessageBox.Show("Algoritmo de Prim aplicado. Las aristas verdes forman el árbol de expansión mínima.",
                      "Prim Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarGrafo_Click(object sender, EventArgs e)
        {
            if (grafo1.VERTICES.Count == 0)
            {
                MessageBox.Show("No hay vértices en el grafo.");
                return;
            }

            visualVertices.Clear();
            visualEdges.Clear();

            DistribuirVerticesEnCirculo();

            foreach (var vertice in grafo1.VERTICES)
            {
                var visualVertice = visualVertices.Find(v => v.Nombre == vertice.dato);
                foreach (var (adyacente, peso) in vertice.Adyacentes)
                {
                    var visualAdyacente = visualVertices.Find(v => v.Nombre == adyacente.dato);

                    bool existe = visualEdges.Any(edge =>
                        (edge.A == visualVertice && edge.B == visualAdyacente) ||
                        (edge.A == visualAdyacente && edge.B == visualVertice));

                    if (!existe && visualVertice != null && visualAdyacente != null)
                    {
                        visualEdges.Add(new VisualEdge(visualVertice, visualAdyacente, peso));
                    }
                }
            }

            panelCanvas.Visible = true;
            panelCanvas.Invalidate();

            grafoCreado = true;
            btnAplicarPrim.Enabled = true;

            MessageBox.Show("Grafo visualizado correctamente.", "Grafo Creado",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DistribuirVerticesEnCirculo()
        {
            int centerX = panelCanvas.Width / 2;
            int centerY = panelCanvas.Height / 2;
            int radio = Math.Min(centerX, centerY) - 80;

            double angulo = 0;
            double incrementoAngulo = 2 * Math.PI / grafo1.VERTICES.Count;

            foreach (var vertice in grafo1.VERTICES)
            {
                int x = centerX + (int)(radio * Math.Cos(angulo));
                int y = centerY + (int)(radio * Math.Sin(angulo));

                visualVertices.Add(new VisualVertex(vertice.dato, new Point(x, y)));
                angulo += incrementoAngulo;
            }
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (var edge in visualEdges)
            {
                edge.Draw(g);
            }

            foreach (var v in visualVertices)
            {
                v.Draw(g);
            }
        }
    }
}