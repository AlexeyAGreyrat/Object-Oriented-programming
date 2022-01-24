using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;

        }
        public Complex(Complex x)
        {
            this.Re = Re;
            this.Im = Im;

        }


        public override string ToString()
        {
            string res = "";

            if (Re != 0.0)
            {
                res = Re.ToString();
            }

            if (Im != 0.0)
            {
                if (Im > 0)
                {
                    res += "+";
                }

                res += Im.ToString() + "i";
            }
            return res;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Re * c2.Re - c1.Im * c2.Im,
                c1.Re * c2.Im + c1.Im * c2.Re);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            double Denominator = c2.Re * c2.Re + c2.Im * c2.Im;
            return new Complex(c1.Re * c2.Re + c1.Im * c2.Im / Denominator,
                c2.Re * c1.Im - c2.Im * c1.Re / Denominator);
        }

    }
}
