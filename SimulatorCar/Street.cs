using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Street
    {
        Image texture;
        List<PointF> points;
        Pen asphalt, line;
        public string Name { get; set; }
        public Street(Image texture)
        {
            this.texture = texture;
            points = new List<PointF>();
            asphalt = new Pen(new TextureBrush(texture), 100);
            line = new Pen(Color.FromArgb(200, Color.White), 3);
            line.DashStyle = DashStyle.Dash;
        }
        public void AddPoint(float x,float y)
        {
            points.Add(new PointF(x, y));
        }
        public void Draw(Graphics g)
        {
            if (points.Count >= 2)
            {   
                g.DrawCurve(asphalt, points.ToArray());
                g.DrawCurve(line, points.ToArray());
                g.DrawString(Name,SystemFonts.DefaultFont, Brushes.White, points[0]);
            }
        }
    }
}
