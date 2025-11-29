using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Ejercicio3
{
    internal class VisualVertex
    {
        public string Nombre { get; set; }
        public Point Position { get; set; }
        public Color Color { get; set; }

        public VisualVertex(string nombre, Point position)
        {
            Nombre = nombre;
            Position = position;
            Color = Color.LightBlue;
        }

        public void Draw(Graphics g)
        {
            
            int radius = 20; 
            Rectangle rect = new Rectangle(
                Position.X - radius,
                Position.Y - radius,
                radius * 2,
                radius * 2
            );

            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                g.FillEllipse(brush, rect);
                g.DrawEllipse(pen, rect);
            }

            
            using (Font font = new Font("Arial", 9, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.Black))
            {
                SizeF textSize = g.MeasureString(Nombre, font);
                g.DrawString(Nombre, font, textBrush,
                            Position.X - textSize.Width / 2,
                            Position.Y - textSize.Height / 2);
            }
        }
    }
}
