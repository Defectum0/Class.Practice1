using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы.Задачи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите номер задания: ");
            switch (Console.ReadLine())
            {
                default:
                case "1":
                    MyNewTask1();
                    break;
                case "2":
                    MyNewTask2();
                    break;
                case "3":
                    MyNewTask3();
                    break;
                case "4":
                    MyNewTask4();
                    break;
                case "5":
                    MyNewTask5();
                    break;
                case "6":
                    MyNewTask6();
                    break;
                case "7":
                    MyNewTask7();
                    break;
                case "8":
                    MyNewTask8();
                    break;
                case "9":
                    MyNewTask9();
                    break;
                case "10":
                    MyNewTask10();
                    break;
                case "11":
                    MyNewTask11();
                    break;
                case "12":
                    MyNewTask12();
                    break;
                case "13":
                    MyNewTask13();
                    break;
                case "14":
                    MyNewTask14();
                    break;
                case "15":
                    MyNewTask15();
                    break;
                case "16":
                    MyNewTask16();
                    break;
                case "17":
                    MyNewTask17();
                    break;
                case "18":
                    MyNewTask18();
                    break;
                case "19":
                    MyNewTask19();
                    break;
                case "20":
                    MyNewTask20();
                    break;
                case "21":
                    MyNewTask21();
                    break;
                case "22":
                    MyNewTask22();
                    break;
                case "23":
                    MyNewTask23();
                    break;
                case "24":
                    MyNewTask24();
                    break;
                case "25":
                    MyNewTask25();
                    break;
                case "26":
                    MyNewTask26();
                    break;
                case "27":
                    MyNewTask27();
                    break;
                case "28":
                    MyNewTask28();
                    break;
                case "29":
                    MyNewTask29();
                    break;
                case "30":
                    MyNewTask30();
                    break;

            }
        }

        public static void MyNewTask1()
        {
            Console.WriteLine("Задание №1");

            double t, l;

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - l");

            l = Convert.ToDouble(Console.ReadLine());

            MyNewTask1 myNewTask1 = new MyNewTask1(t, l);
            myNewTask1.R();
        }
        public static void MyNewTask2()
        {
            Console.WriteLine("Задание №2");

            double p, y, e;

            Console.WriteLine("Введите значение - p");

            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            MyNewTask2 myNewTask2 = new MyNewTask2(p, y, e);
            myNewTask2.K();

        }
        public static void MyNewTask3()
        {
            Console.WriteLine("Задание №3");
            double n, y;

            Console.WriteLine("Введите значение - n");

            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask3 myNewTask3 = new MyNewTask3(n, y);
            myNewTask3.G();
        }
        public static void MyNewTask4()
        {
            Console.WriteLine("Задание №4");
            double a, t;

            Console.WriteLine("Введите значение - a");

            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            MyNewTask4 myNewTask4 = new MyNewTask4(a, t);
            myNewTask4.D();
        }
        public static void MyNewTask5()
        {
            Console.WriteLine("Задание №5");
            double x;

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask5 myNewTask5 = new MyNewTask5(x);
            myNewTask5.L();
        }
        public static void MyNewTask6()
        {
            Console.WriteLine("Задание №6");
            double y, e, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask6 myNewTask6 = new MyNewTask6(y, e, x);
            myNewTask6.M();
        }
        public static void MyNewTask7()
        {
            Console.WriteLine("Задание №7");
            double m;

            Console.WriteLine("Введите значение - m");

            m = Convert.ToDouble(Console.ReadLine());

            MyNewTask7 myNewTask7 = new MyNewTask7(m);
            myNewTask7.N();
        }
        public static void MyNewTask8()
        {
            Console.WriteLine("Задание №8");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask8 myNewTask8 = new MyNewTask8(y);
            myNewTask8.T();
        }
        public static void MyNewTask9()
        {
            Console.WriteLine("Задание №9");
            double y, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask9 myNewTask9 = new MyNewTask9(y, x);
            myNewTask9.V();
        }
        public static void MyNewTask10()
        {
            Console.WriteLine("Задание №10");
            double e, y, k, x;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - k");

            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask10 myNewTask10 = new MyNewTask10(e, y, k, x);
            myNewTask10.U();
        }
        public static void MyNewTask11()
        {
            Console.WriteLine("Задание №11");
            double y, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask11 myNewTask11 = new MyNewTask11(y, x);
            myNewTask11.S();
        }
        public static void MyNewTask12()
        {
            Console.WriteLine("Задание №12");
            double t, x;

            Console.WriteLine("Введите значение - t");

            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask12 myNewTask12 = new MyNewTask12(t, x);
            myNewTask12.K();
        }
        public static void MyNewTask13()
        {
            Console.WriteLine("Задание №13");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask13 myNewTask13 = new MyNewTask13(y);
            myNewTask13.E();
        }
        public static void MyNewTask14()
        {
            Console.WriteLine("Задание №14");
            double y, e, x;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask14 myNewTask14 = new MyNewTask14(y, e, x);
            myNewTask14.R();
        }
        public static void MyNewTask15()
        {
            Console.WriteLine("Задание №15");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask15 myNewTask15 = new MyNewTask15(y);
            myNewTask15.H();
        }
        public static void MyNewTask16()
        {
            Console.WriteLine("Задание №16");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask16 myNewTask16 = new MyNewTask16(y);
            myNewTask16.S();
        }
        public static void MyNewTask17()
        {
            Console.WriteLine("Задание №17");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask17 myNewTask17 = new MyNewTask17(y);
            myNewTask17.N();
        }
        public static void MyNewTask18()
        {
            Console.WriteLine("Задание №18");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask18 myNewTask18 = new MyNewTask18(y);
            myNewTask18.Z();
        }
        public static void MyNewTask19()
        {
            Console.WriteLine("Задание №19");
            double n, y, g;

            Console.WriteLine("Введите значение - n");

            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - g");

            g = Convert.ToDouble(Console.ReadLine());

            MyNewTask19 myNewTask19 = new MyNewTask19(n, y, g);
            myNewTask19.P();
        }
        public static void MyNewTask20()
        {
            Console.WriteLine("Задание №20");
            double e, k, y, x;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - k");

            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask20 myNewTask20 = new MyNewTask20(e, k, y, x);
            myNewTask20.U();
        }
        public static void MyNewTask21()
        {
            Console.WriteLine("Задание №21");
            double e, y, h;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - h");

            h = Convert.ToDouble(Console.ReadLine());

            MyNewTask21 myNewTask21 = new MyNewTask21(e, y, h);
            myNewTask21.P();
        }
        public static void MyNewTask22()
        {
            Console.WriteLine("Задание №22");
            double u, y, x;

            Console.WriteLine("Введите значение - u");

            u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask22 myNewTask22 = new MyNewTask22(u, y, x);
            myNewTask22.T();
        }
        public static void MyNewTask23()
        {
            Console.WriteLine("Задание №23");
            double e, y, f;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - f");

            f = Convert.ToDouble(Console.ReadLine());

            MyNewTask23 myNewTask23 = new MyNewTask23(e, y, f);
            myNewTask23.G();
        }
        public static void MyNewTask24()
        {
            Console.WriteLine("Задание №24");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask24 myNewTask24 = new MyNewTask24(y);
            myNewTask24.F();
        }
        public static void MyNewTask25()
        {
            Console.WriteLine("Задание №25");
            double e, y, f;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - f");

            f = Convert.ToDouble(Console.ReadLine());

            MyNewTask25 myNewTask25 = new MyNewTask25(e, y, f);
            myNewTask25.G();
        }
        public static void MyNewTask26()
        {
            Console.WriteLine("Задание №26");
            double p;

            Console.WriteLine("Введите значение - p");

            p = Convert.ToDouble(Console.ReadLine());

            MyNewTask26 myNewTask26 = new MyNewTask26(p);
            myNewTask26.Z();
        }
        public static void MyNewTask27()
        {
            Console.WriteLine("Задание №27");
            double v, e, y, x;

            Console.WriteLine("Введите значение - v");

            v = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - x");

            x = Convert.ToDouble(Console.ReadLine());

            MyNewTask27 myNewTask27 = new MyNewTask27(v, e, y, x);
            myNewTask27.W();
        }
        public static void MyNewTask28()
        {
            Console.WriteLine("Задание №28");
            double e, y, h;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - h");

            h = Convert.ToDouble(Console.ReadLine());

            MyNewTask28 myNewTask28 = new MyNewTask28(e, y, h);
            myNewTask28.T();
        }
        public static void MyNewTask29()
        {
            Console.WriteLine("Задание №29");
            double y;

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            MyNewTask29 myNewTask29 = new MyNewTask29(y);
            myNewTask29.N();
        }
        public static void MyNewTask30()
        {
            Console.WriteLine("Задание №30");
            double e, y, r;

            Console.WriteLine("Введите значение - e");

            e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - y");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение - r");

            r = Convert.ToDouble(Console.ReadLine());

            MyNewTask30 myNewTask30 = new MyNewTask30(e, y, r);
            myNewTask30.W();
        }
    }
}
        
    

