using System;

namespace DemoProject
{
    struct Complex
    {
        public double a, b;
        public string c;


        public Complex(double v1, double v2, string znack)
        {
            a = v1;
            b = v2;
            c = znack;
        }

        public void Print()
        {
            string temp = String.Empty;

            if (a == 0) temp = $"";
            else temp = $"{a}";

            if (b == 0) temp += $"";
            else if (b > 0) temp +=  $" {c} {b}i";
            else temp += $" {c} {-b}i";
            if (a == 0 && b == 0) temp = "0";


            Console.WriteLine(temp);
        }


        //сложение
        public static Complex Sum(Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.a + z2.a, z1.b +z2.b, "+");

            return res;
        }
        //Вычитание
        public static Complex Vich(Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.a - z2.a, z1.b - z2.b, "-");

            return res;
        }
        //Умножение
        public static Complex Prois(Complex z1, Complex z2)
        {
            Complex res = new Complex(z1.a * z2.a - z1.b * z2.b, z1.a * z2.b + z1.b * z2.a, "*");

            return res;
        }

    }
}