using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using tamrin_kodam;

namespace tamrin_kodam
{
    public class Crcle
    {
        private int r;
        public double pi = 3.14;

        public Crcle() { }
        public Crcle(int r)
        {
            this.r = r;
        }

        public double p()
        {
            return r * pi * 2;
        }
        public double s()
        {
            return Math.Pow(r, 2) * pi;
        }
    }

    public class Square
    {
        private int a;
        public Square() { }
        public Square(int a)
        {
            this.a = a;
        }
        public double p()
        {
            return a * 4;
        }
        public double s()
        {
            return a * a;
        }
    }

    public class Triangle
    {
        private double a;//ضلغ

        private double b;// ارتفاع
        private double c;// قاعده
        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double p()
        {
            return a * 3;
        }
        public double s()
        {
            return (b * c) / 2;
        }
    }

    public class Trapezoid
    {
        private double a;//ساق ها
        private double b;//قاعده بزرگ
        private double c;//قاعده کوچک
        private double d;//ارتفاع

        public Trapezoid() { }
        public Trapezoid(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double p()
        {
            return (a + 2) + b + c;
        }
        public double s()
        {
            return (b + c) / 2 * d;
        }
    }

    public class Oval
    {
        private double a;//شعاع کوچک
        private double b;//شعاع بزرگ
        public double pi = 3.14;
        public Oval() { }

        public Oval(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double p()
        {
            return ((a + b) / 2) * pi * 2;
        }
        public double s()
        {
            return a * b * pi;
        }
    }

    public class Polygon
    {
        private double a;//طول ضلغ
        private double n;//تعداد ضلع
        private double b;//ارتفاع

        public Polygon() { }
        public Polygon(double a, double b, double n)
        {
            this.a = a;
            this.b = b;
            this.n = n;
        }
        public double p()
        {
            return n * a;
        }
        public double s()
        {
            return (b * p()) / 2;
        }
    }

    public class Rectangle
    {
        private double a;
        private double b;

        public Rectangle() { }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double p()
        {
            return (a + b) * 2;
        }
        public double s()
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" adad shekl mored nazar re vared konin ");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x == 1)
            {
                Console.WriteLine(" shekl daire ");
                int r = Convert.ToInt32(Console.ReadLine());
                Crcle c = new Crcle(r);
                Console.WriteLine(" mohit = " + c.p() + " masahat = " + c.s());
            }
            else if (x == 2)
            {
                Console.WriteLine(" shekl moraba ");
                int a = Convert.ToInt32(Console.ReadLine());
                Square s = new Square(a);
                Console.WriteLine(" masahat = " + s.s() + " mohit = " + s.p());
            }
            else if (x == 3)
            {
                Console.WriteLine(" shekl mosalas ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                Triangle t = new Triangle(a, b, c);
                Console.WriteLine(" mohit = " + t.p() + " masahat = " + t.s());
            }
            else if (x == 4)
            {
                Console.WriteLine(" shekl zozanaghe ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double C = Convert.ToDouble(Console.ReadLine());
                double d = Convert.ToDouble(Console.ReadLine());
                Trapezoid t = new Trapezoid(a, b, C, d);
                Console.WriteLine(" mohit = " + t.p() + " masahat = " + t.s());
            }
            else if (x == 5)
            {
                Console.WriteLine(" shekl beizi ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Oval o = new Oval(a, b);
                Console.WriteLine(" mohit = " + o.p() + " masaat = " + o.s());
            }
            else if (x == 6)
            {
                Console.WriteLine(" shekl chandzeli ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double n = Convert.ToDouble(Console.ReadLine());
                Polygon p = new Polygon(a, b, n);
                Console.WriteLine(" mohit = " + p.p() + " masahat = " + p.s());
            }
            else if (x == 7)
            {
                Console.WriteLine(" shekl mostatil ");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Rectangle re = new Rectangle(a, b);
                Console.WriteLine(" mohit = " + re.p() + " masahat = " + re.s());
            }
            else
            {
                Console.WriteLine(" adad eshtebah ");
            }
        }
    }
}
