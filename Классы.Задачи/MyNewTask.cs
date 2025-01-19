using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы.Задачи
{
        public class MyNewTask1
        {
            public MyNewTask1(double l, double t)
            {
                this._l = l;
                this._t = t;
            }
            private double _l;
            private double _t;

            public void R()
            {
                Console.WriteLine($"R = {3 * Math.Pow(_t, 2) + 3 * Math.Pow(_l, 5) + 4.9}");
            }
        }
        public class MyNewTask2
        {
            public MyNewTask2(double p, double y, double e)
            {
                this._p = p;
                this._y = y;
                this._e = e;
            }
            private double _p;
            private double _y;
            private double _e;

            public void K()
            {
                Console.WriteLine($"K = {Math.Log10(Math.Pow(_p, 2) + Math.Pow(_y, 3) + Math.Pow(_e, _p))}");
            }
        }
        public class MyNewTask3
        {
            public MyNewTask3(double n, double y)
            {
                this._n = n;
                this._y = y;
            }
            private double _n;
            private double _y;

            public void G()
            {
                Console.WriteLine($"G = {_n * (_y + 3.5) + Math.Sqrt(_y)}");
            }
        }
        public class MyNewTask4
        {
            public MyNewTask4(double a, double t)
            {
                this._a = a;
                this._t = t;
            }
            private double _a;
            private double _t;

            public void D()
            {
                Console.WriteLine($"D = {9.8 * Math.Pow(_a, 2) + 5.52 * Math.Cos(Math.Pow(_t, 5))}");
            }
        }
        public class MyNewTask5
        {
            public MyNewTask5(double x)
            {
                this._x = x;
            }
            private double _x;

            public void L()
            {
                Console.WriteLine($"L = {1.51 * Math.Cos(Math.Pow(_x, 2)) + 2 * Math.Pow(_x, 3)}");
            }
        }
        public class MyNewTask6
        {
            public MyNewTask6(double y, double e, double x)
            {
                this._y = y;
                this._e = e;
                this._x = x;
            }
            private double _y;
            private double _e;
            private double _x;

            public void M()
            {
                Console.WriteLine($"M = {Math.Cos(2) * _y + 3.6 * Math.Pow(_e, _x)}");
            }
        }
        public class MyNewTask7
        {
            public MyNewTask7(double m)
            {
                this._m = m;
            }
            private double _m;

            public void N()
            {
                Console.WriteLine($"N = {Math.Pow(_m, 2) + 2.8 * Math.Abs(_m) + 0.55}");
            }
        }
        public class MyNewTask8
        {
            public MyNewTask8(double y)
            {
                this._y = y;
            }
            private double _y;

            public void T()
            {
                Console.WriteLine($"T = {Math.Sqrt(Math.Abs(6 * Math.Pow(_y, 2) - 0.1 * _y + 4))}");
            }
        }
        public class MyNewTask9
        {
            public MyNewTask9(double y, double x)
            {
                this._y = y;
                this._x = x;
            }
            private double _y;
            private double _x;

            public void V()
            {
                Console.WriteLine($"V = {Math.Log10(_y + 0.95) + Math.Sin(Math.Pow(_x, 4))}");
            }
        }
        public class MyNewTask10
        {
            public MyNewTask10(double e, double y, double k, double x)
            {
                this._e = e;
                this._y = y;
                this._k = k;
                this._x = x;
            }
            private double _e;
            private double _y;
            private double _k;
            private double _x;

            public void U()
            {
                Console.WriteLine($"U = {Math.Pow(_e, _y) + 7.355 * Math.Pow(_k, 2) + Math.Pow(Math.Sin(_x), 2)}");
            }
        }
        public class MyNewTask11
        {
            public MyNewTask11(double y, double x)
            {
                this._y = y;
                this._x = x;
            }
            private double _y;
            private double _x;

            public void S()
            {
                Console.WriteLine($"S = {9.75 * Math.Pow(_y, 7) + 2 * Math.Tan(_x)}");
            }
        }
        public class MyNewTask12
        {
            public MyNewTask12(double t, double x)
            {
                this._t = t;
                this._x = x;
            }
            private double _t;
            private double _x;

            public void K()
            {
                Console.WriteLine($"K = {7 * Math.Pow(_t, 2) + 3 * Math.Sin(Math.Pow(_x, 3)) + 9.2}");
            }
        }
        public class MyNewTask13
        {
            public MyNewTask13(double y)
            {
                this._y = y;
            }
            private double _y;

            public void E()
            {
                Console.WriteLine($"E = {Math.Sqrt(Math.Abs(3 * Math.Pow(_y, 2) + 0.5 * _y + 4))}");
            }
        }
        public class MyNewTask14
        {
            public MyNewTask14(double y, double e, double x)
            {
                this._y = y;
                this._e = e;
                this._x = x;
            }
            private double _y;
            private double _e;
            private double _x;
            public void R()
            {
                Console.WriteLine($"R = {Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(_y), 2) + 6.835 + Math.Pow(_e, _x)))}");
            }
        }
        public class MyNewTask15
        {
            public MyNewTask15(double y)
            {
                this._y = y;
            }
            private double _y;

            public void H()
            {
                Console.WriteLine($"H = {Math.Sin(Math.Pow(_y, 2)) - 2.8 * _y + Math.Sqrt(Math.Abs(_y))}");
            }
        }
        public class MyNewTask16
        {
            public MyNewTask16(double y)
            {
                this._y = y;
            }
            private double _y;

            public void S()
            {
                Console.WriteLine($"S = {Math.Sqrt(Math.Cos(4) * Math.Pow(_y, 2) + 7.151)}");
            }
        }
        public class MyNewTask17
        {
            public MyNewTask17(double y)
            {
                this._y = y;
            }
            private double _y;

            public void N()
            {
                Console.WriteLine($"N = {3 * Math.Pow(_y, 2) + Math.Sqrt(_y + 1)}");
            }
        }
        public class MyNewTask18
        {
            public MyNewTask18(double y)
            {
                this._y = y;
            }
            private double _y;

            public void Z()
            {
                Console.WriteLine($"Z = {3 * Math.Pow(_y, 2) + Math.Sqrt(Math.Pow(_y, 3) + 1)}");
            }
        }
        public class MyNewTask19
        {
            public MyNewTask19(double n, double y, double g)
            {
                this._n = n;
                this._y = y;
                this._g = g;
            }
            private double _n;
            private double _y;
            private double _g;

            public void P()
            {
                Console.WriteLine($"P = {_n * Math.Sqrt(Math.Pow(_y, 3) + 1.09 * _g)}");
            }
        }
        public class MyNewTask20
        {
            public MyNewTask20(double e, double k, double y, double x)
            {
                this._e = e;
                this._k = k;
                this._y = y;
                this._x = x;
            }
            private double _e;
            private double _k;
            private double _y;
            private double _x;

            public void U()
            {
                Console.WriteLine($"U = {Math.Pow(_e, _k + _y) + Math.Tan(_x) * Math.Sqrt(_y)}");
            }
        }
        public class MyNewTask21
        {
            public MyNewTask21(double e, double y, double h)
            {
                this._e = e;
                this._y = y;
                this._h = h;
            }
            private double _e;
            private double _y;
            private double _h;

            public void P()
            {
                Console.WriteLine($"P = {Math.Pow(_e, _y + 5.5) + 9.1 * Math.Pow(_h, 3)}");
            }
        }
        public class MyNewTask22
        {
            public MyNewTask22(double u, double y, double x)
            {
                this._u = u;
                this._y = y;
                this._x = x;
            }
            private double _u;
            private double _y;
            private double _x;

            public void T()
            {
                Console.WriteLine($"T = {Math.Sin(2 * _u) * Math.Log10(2 * Math.Pow(_y, 2) + Math.Sqrt(_x))}");
            }
        }
        public class MyNewTask23
        {
            public MyNewTask23(double e, double y, double f)
            {
                this._e = e;
                this._y = y;
                this._f = f;
            }
            private double _e;
            private double _y;
            private double _f;

            public void G()
            {
                Console.WriteLine($"G = {Math.Pow(_e, 2 * _y) + Math.Sin(_f)}");
            }
        }
        public class MyNewTask24
        {
            public MyNewTask24(double y)
            {
                this._y = y;
            }
            private double _y;

            public void F()
            {
                Console.WriteLine($"F = {2 * Math.Sin(0.214 * Math.Pow(_y, 5) + 1)}");
            }
        }
        public class MyNewTask25
        {
            public MyNewTask25(double e, double y, double f)
            {
                this._e = e;
                this._y = y;
                this._f = f;
            }
            private double _e;
            private double _y;
            private double _f;

            public void G()
            {
                Console.WriteLine($"G = {Math.Pow(_e, 2 * _y) + Math.Sin(Math.Pow(_f, 2))}");
            }
        }
        public class MyNewTask26
        {
            public MyNewTask26(double p)
            {
                this._p = p;
            }
            private double _p;

            public void Z()
            {
                Console.WriteLine($"Z = {Math.Sin(Math.Pow((Math.Pow(_p, 2) + 0.4), 3))}");
            }
        }
        public class MyNewTask27
        {
            public MyNewTask27(double v, double e, double y, double x)
            {
                this._v = v;
                this._e = e;
                this._y = y;
                this._x = x;
            }
            private double _v;
            private double _e;
            private double _y;
            private double _x;

            public void W()
            {
                Console.WriteLine($"W = {1.03 * _v + Math.Pow(_e, 2 * _y) + Math.Tan(Math.Abs(_x))}");
            }
        }
        public class MyNewTask28
        {
            public MyNewTask28(double e, double y, double h)
            {
                this._e = e;
                this._y = y;
                this._h = h;
            }
            private double _e;
            private double _y;
            private double _h;

            public void T()
            {
                Console.WriteLine($"T = {Math.Pow(_e, _y + _h) + Math.Sqrt(Math.Abs(6.4 * _y))}");
            }
        }
        public class MyNewTask29
        {
            public MyNewTask29(double y)
            {
                this._y = y;
            }
            private double _y;

            public void N()
            {
                Console.WriteLine($"N = {3 * Math.Pow(_y, 2) + Math.Sqrt(Math.Abs(_y + 1))}");
            }
        }
        public class MyNewTask30
        {
            public MyNewTask30(double e, double y, double r)
            {
                this._e = e;
                this._y = y;
                this._r = r;
            }
            private double _e;
            private double _y;
            private double _r;

            public void W()
            {
                Console.WriteLine($"W = {Math.Pow(_e, _y + _r) + 7.2 * Math.Sin(_r)}");
            }
        }
    

}

