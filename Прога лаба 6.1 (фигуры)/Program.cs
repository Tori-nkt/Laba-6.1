using System;

namespace Прога_лаба_6._1__фигуры_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure c = new Cylinder(3, 1);
            c.volume();
            c.square();
            c.print();
            Figure conus = new Cone(3, 1, 2);
            conus.volume();
            conus.square();
            conus.print();
            Figure con = new Conoid(2, 1, 2, 3);
            con.volume();
            con.square();
            con.print();

        }
    }
    abstract class Figure
    {
        public double h { get; set; }
        public double r { get; set; }
        public Figure(double H, double R)
        {
            h = H;
            r = R;
        }
        public virtual void square(){}
        public virtual void volume() {}
        public virtual void print()
        {
            Console.WriteLine($"Высота:{h} радиус:{r}");
        }
    }
    class Cylinder : Figure
    {
        
        public double s, v;
        public Cylinder(double h, double r)
            : base(h, r) { }
        public override void square() 
        {
            s = (2 * 3.14 * r * (h + r));
        }
        
        public override void volume()
        {
            v = (r * r * 3.14 * h);
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Площадь цилиндра: {s}, объём: {v}");
        }
    }
    class Cone : Figure
    {

        public double s, v;
        /// constructor
        public double l { get; set; }
        public Cone(double h, double r, double L)
            : base(h, r) {l = L; }
        /// override methods
        public override void volume()
        {
            v = (1.0 / 3) * r * r * 3.14 * h;
        }
        public override void square()
        {

            s = (r * r * 3.14) + (3.14 * r * l);
            
        }
        
        public override void print()
        {
            base.print();
            Console.WriteLine($"Твiрна конуса: {l}");
            Console.WriteLine($"Площадь конуса: {s}, объём: {v}");
        }
    }
    class Conoid : Figure
    {
        public double s;
        public double v;
        public double l { get; set; }
        public double R { get; set; }
        public Conoid(double h, double r, double L, double Ra)
            : base(h, r)
        {
            l = L;
            R = Ra;
        }
        public override void square()
        {
            s = (3.14*(r * r + R * R + R*l + l*r));
        }
        public override void volume()
        {
            v = (1.0 / 3 * 3.14 * h*(r * r + R*r + r*r));
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Площадь усечённого конуса: {s}, объём: {v}");
        }
    }
}
