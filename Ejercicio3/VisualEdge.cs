using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class VisualEdge
    {
        public VisualVertex A { get; set; }
        public VisualVertex B { get; set; }
        public int Peso { get; set; }
        public Color Color { get; set; } 
        public bool IsMST { get; set; } 

        public VisualEdge(VisualVertex a, VisualVertex b, int peso)
        {
            A = a;
            B = b;
            Peso = peso;
            Color = Color.Black;
            IsMST = false;
        }

        public void Draw(Graphics g)
        {
            using (var pen = new Pen(Color, IsMST ? 4f : 2f))
            {
                g.DrawLine(pen, A.Position, B.Position);
            }

            PointF textPosition = CalculateTextPosition(g);

            PointF center = new PointF(
            (A.Position.X + B.Position.X) / 2,
            (A.Position.Y + B.Position.Y) / 2
            );

            using (Font font = new Font("Arial", 10, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.Red)) 
            using (Brush backgroundBrush = new SolidBrush(Color.White)) 
            {
                string text = Peso.ToString();
                SizeF textSize = g.MeasureString(text, font);

               
                RectangleF backgroundRect = new RectangleF(
                    center.X - textSize.Width / 2 - 2,
                    center.Y - textSize.Height / 2 - 2,
                    textSize.Width + 4,
                    textSize.Height + 4
                );

                g.FillRectangle(backgroundBrush, backgroundRect);
                g.DrawRectangle(new Pen(Color.Black, 1),
                              backgroundRect.X, backgroundRect.Y,
                              backgroundRect.Width, backgroundRect.Height);

                
                g.DrawString(text, font, textBrush,
                            center.X - textSize.Width / 2,
                            center.Y - textSize.Height / 2);
            }
        }
        private PointF CalculateTextPosition(Graphics g)
        {
            PointF center = new PointF(
                (A.Position.X + B.Position.X) / 2,
                (A.Position.Y + B.Position.Y) / 2
            );

            
            float dx = B.Position.X - A.Position.X;
            float dy = B.Position.Y - A.Position.Y;
            float angle = (float)Math.Atan2(dy, dx);

            
            float offsetDistance = 20f;

           
            PointF perpendicularOffset = new PointF(
                (float)(-Math.Sin(angle) * offsetDistance),
                (float)(Math.Cos(angle) * offsetDistance)
            );

            return new PointF(center.X + perpendicularOffset.X, center.Y + perpendicularOffset.Y);
        }

        public bool MatchesNames(string nameA, string nameB, int peso)
        {
            return Peso == peso && ((A.Nombre == nameA && B.Nombre == nameB) || (A.Nombre == nameB && B.Nombre == nameA));
        }
    }
}
