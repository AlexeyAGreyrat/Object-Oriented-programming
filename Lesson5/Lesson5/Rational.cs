using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        private void Reduce1()
        {
            this.Numerator = this.Numerator > 0 ? this.Numerator : -this.Numerator;
            this.Denominator = this.Denominator > 0 ? this.Denominator : -this.Denominator;

            int maxval = Numerator > Denominator ? Numerator : Denominator;
            for (int i = maxval; i >= 2; maxval--)
            {
                if (Numerator % maxval == 0 && Denominator % maxval == 0)
                {
                    this.Numerator /= maxval;
                    this.Denominator /= maxval;
                    break;
                }
            }
        }
        public bool IsNan
        {
            get { return this.Denominator != 0 ? false : true; }
        }

        public Rational(int numerator, int denominator = 1)
        {
            if (numerator == 0)
            {
                this.Numerator = 0;
                this.Denominator = 1;
            }
            else if (numerator == denominator)
            {
                this.Numerator = 1;
                this.Denominator = 1;
            }
            else if (numerator > 0 && denominator > 0 || numerator < 0 && denominator < 0)
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
                Reduce1();

            }
            else if (numerator < 0 || denominator < 0)
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
                Reduce1();
                this.Numerator *= -1;
            }
        }

        private static int NOZ(int[] maxmin)
        {
            Array.Sort(maxmin);
            if (maxmin[1] % maxmin[0] == 0)
                return maxmin[1];

            int temp = 0;
            for (int i = 2; ; i++)
            {
                temp = maxmin[1] * i;
                if (temp % maxmin[0] == 0)
                {
                    break;
                }
            }
            return temp;
        }


        public static Rational operator *(Rational a, int b)
        {
            return new Rational(a.Numerator * b, a.Denominator);
        }

        //Складываем рациональную дробь с рациональной дробью
        public static Rational operator +(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
               return new Rational(1, 0);

            Rational result1 = new Rational(1), result2 = new Rational(1);
            int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
            result1.Numerator = noz / a.Denominator * a.Numerator;
            result2.Numerator = noz / b.Denominator * b.Numerator;
            return new Rational(result1.Numerator + result2.Numerator, noz);
        }

        //Вычитаем рациональную дробь на рациональную дробь
        public static Rational operator -(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            Rational result1 = new Rational(1), result2 = new Rational(1);
            int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
            result1.Numerator = noz / a.Denominator * a.Numerator;
            result2.Numerator = noz / b.Denominator * b.Numerator;
            return new Rational(result1.Numerator - result2.Numerator, noz);
        }

        //Умножаем рациональную дробь на рациональную дробь
        public static Rational operator *(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        //Делим рациональную дробь на рациональную дробь
        public static Rational operator /(Rational a, Rational b)
        {
            if (a.Denominator == 0 || b.Numerator == 0 || b.Denominator == 0)
                return new Rational(1, 0);

            return new Rational(a.Numerator / b.Numerator, a.Denominator / b.Denominator);
        }

        //Переопределяем метод ToString() для удобства вывода на экран
        public override string ToString()
        {
            return String.Format("[Rational: {0}/{1}]", this.Numerator, this.Denominator);
        }

        public static explicit operator int(Rational a)
        {
            if (a.Numerator < a.Denominator || a.Denominator == 0)
                throw new ArgumentException();

            return (int)(a.Numerator / a.Denominator);
        }

        public static implicit operator float(Rational a)
        {
            return (float)a.Numerator / (float)a.Denominator;
        }

        public bool Equals(Rational a, Rational b)
        {
            if ( a.Numerator == b.Numerator && a.Denominator == b.Denominator )
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator < result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (a.Numerator < b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator >(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator > result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (a.Numerator > b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator >=(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator >= result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (a.Numerator >= b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator <=(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator <= result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (a.Numerator <= b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool operator ==(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator == result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if(a.Numerator == b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator !=(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            if (a.Denominator != b.Denominator)
            {
                int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
                result1.Numerator = noz / a.Denominator * a.Numerator;
                result2.Numerator = noz / b.Denominator * b.Numerator;
                if (result1.Numerator != result2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (a.Numerator != b.Numerator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Rational operator ++(Rational a)
        {
            return new Rational(a.Numerator+a.Denominator,a.Denominator);
        }

        public static Rational operator --(Rational a)
        {
            return new Rational(a.Numerator - a.Denominator, a.Denominator);
        }

        public static int operator %(Rational a, Rational b)
        {
            Rational result1 = new Rational(1), result2 = new Rational(1);
            int noz = NOZ(new int[2] { a.Denominator, b.Denominator });
            result1.Numerator = noz / a.Denominator * a.Numerator;
            result2.Numerator = noz / b.Denominator * b.Numerator;
            if (result1.Numerator / result2.Numerator == 1)
            { 
                return 0;
            }
            else
            {
                int temp = 0;
                for (int i = 0; ; i++)
                {
                    temp=i;
                    if (result1.Numerator / result2.Numerator == 1)
                    {
                        break;
                    }
                    result2.Numerator = result2.Numerator - 1;
                }
                return temp;
            }
                        
        }
    }
}
