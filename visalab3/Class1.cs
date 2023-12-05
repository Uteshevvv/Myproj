using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace visalab3
{
    public abstract class Body
    {
        protected double AreaSurface { get; set; }
        protected double Volume { get; set; }

        public abstract double mAreaSurface();
        public abstract double mVolume();
        /*   public void GetText()
           {
               Console.WriteLine("Объем:");
           }*/
    }

    public class Parallelepiped : Body
    {
        public Parallelepiped(double a, double b, double c)
        {
            Height = a;
            Width = b;
            Length = c;
        }

        public double Height { get; }
        public double Width { get; }
        public double Length { get; }

        public override double mAreaSurface()
        {
            double s = 2 * (Height * Width + Width * Length + Height * Length);
            return s;
        }
        public override double mVolume()
        {
            double v = Height * Width * Length;
            return v;
        }

    }

    public class Pipe : Parallelepiped
    {
        
        public Pipe(double a, double b, double c, double ee) : base(a, b, c)
        {
            Thickness = ee;
            Height2 = Height - Thickness;
            Width2 = Width - Thickness;

        }
        private double Height2 { get; }
        private double Width2 { get; }
        private double Thickness { get; }


        public override double mVolume()
        {
            double vol1 = base.mVolume();

            Body obj;
            obj = new Parallelepiped(Width2, Height2, Length);
            double vol2 = obj.mVolume();

            double v = vol1 - vol2;
            return v;
        }
    }
    public class Ball : Body
    {
        public Ball(double r) { Radius = r; }
        private double Radius { get; }

        public override double mAreaSurface()
        {
            double s = 4 * Math.PI * Radius * Radius;
            return Math.Round(s, 3);
        }
        public override double mVolume()
        {
            double v = (4 / 3) * Math.PI * Radius * Radius * Radius;
            return Math.Round(v, 3);
        }

    }
}
