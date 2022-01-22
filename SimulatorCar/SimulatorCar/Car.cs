using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Car
    {
        Image image;
        public bool left, right, gas, brake, handbrake;
        public Car(Image image, float x, float y)
        {
            this.image = image;
            X = x;
            Y = y;
        }
        float drift;
        public float X { get; set; }
        public float Y { get; set; }
        public float V { get; set; }
        public float Direction { get; set; }
        public void Operate(float dt)
        {
            float s = V * dt;
            X += (float)(s * Math.Cos(Direction * Math.PI / 180));
            Y += (float)(s * Math.Sin(Direction * Math.PI / 180));
            if (left && V > 0)
            {
                Direction -= 60f * dt;
            }
            if (right && V > 0)
            {
                Direction += 60f * dt;
            }
            if (gas && V < 1000)
            {
                V += 50 * dt;
            }
            if (brake && V > 0)
            {
                V -= 100 * dt;
                if (V < 0) V = 0;
            }
            if (handbrake && V > 0)
            {
                if (left)
                {
                    if (drift > -30) drift -= 1;
                }
                else
                if (right)
                {
                    if (drift < 30) drift += 1;
                }
            }
            else
            {
                if (drift != 0)
                    drift -= 1 * Math.Sign(drift);
            }
        } 
        public void Draw(Graphics g)
        {
            var m = g.Transform;
           
            g.TranslateTransform(X, Y);
            g.RotateTransform(Direction+90+drift);
            g.ScaleTransform(0.3f, 0.3f);
            g.DrawImage(image, -0.85f*image.Width / 2, -1.3f*image.Height / 2);
            g.Transform = m;
        }
    }
}
