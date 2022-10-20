using System;
using System.Xml.Linq;


class Homework
{
    static void Main()
    {
       
        {
            // TASK_1

            Console.WriteLine("Enter the number1:");
            var numberToString = Console.ReadLine();
            int q = Convert.ToInt32(numberToString);
            double w = Convert.ToDouble(numberToString);
            char r = Convert.ToChar(numberToString);
            float t = Convert.ToSingle(numberToString);
            Console.WriteLine($" {q}, {w}, {r}, {t}");
            Console.ReadLine();

        }

        {
            // TASK_2

            Console.WriteLine("Enter the number2:");
            var numberToString = Console.ReadLine();
            int a = int.Parse(numberToString);
            Console.WriteLine("Enter the number2:");
            var numberToString1 = Console.ReadLine();
            double b = double.Parse(numberToString);
           

        }

        {
            // TASK_3

            Console.WriteLine("Enter the number3:");
            var numberToString = Console.ReadLine();
            int c;

            var isNumber = int.TryParse(numberToString, out c);
            Console.WriteLine($"Number is {c}");
            Console.WriteLine("Success");

        }

        {
            // TASK_4

            Console.WriteLine("Enter the number4:");
            var numberToString = Console.ReadLine();
            int d;
            var isNumber = int.TryParse(numberToString, out d);
            int e = d + 3;
            int f = e + d;
            Console.WriteLine($" {d}, {e}, {f}");
            Console.ReadLine();

        }

        {
            // Task_5

            string s1 = "Apples";
            double w1 = 2.32;
            string s2 = "Juice";
            double w2 = 2.05;
            string s3 = "Milk";
            double w3 = 1.56;
            string s4 = "Cucumber";
            double w4 = 2;
            string s5 = "Cake";
            double w5 = 6;
            string s6 = s1 + w1;
            string s7 = s2 + w2;
            string s8 = s3 + w3;
            string s9 = s4 + w4;
            string s10 = s5 + w5;
            string s11 = "All";
            double w6 = ((w1 + w2 + w3 + w4 + w5) - (w1 + w2 + w3 + w4 + w5)*0.15);
            string s13 = s11 + w6;
            Console.WriteLine($"{s6}");
            Console.WriteLine($"{s7}");
            Console.WriteLine($"{s8}");
            Console.WriteLine($"{s9}");
            Console.WriteLine($"{s10}");
            Console.WriteLine($"{s13}");
            Console.ReadLine();

        }

        {
            // Task_6 

            
            int p = 6 ; // p++ = 7
            int l = 5; // --l = 4
            int i = p++ + l; // i = 7 + 4  = 11
            int u = --l * p;  // u = 4 * 7 =28
            Console.WriteLine($" {p}, {l}, {i}, {u}");
            Console.ReadLine();
            // ВОПРОС: Почему в выражения подставлялись сразу измененные ОБА значения??? Я переделывал и так и оставалось. 
            // В чем ошибка? или всё верно?
        }

        {
            // Task_7
            bool qw = true;
            bool rw = !qw;

            int ee = 2;
            int rr = 2;
            bool tt = ee == rr;
            bool tt1 = ee != rr;
            Console.WriteLine($" {tt}, {tt1}");
            Console.ReadLine();

            int qq = 3;
            int ww = 3;
            int pp = 3;
            bool aa = qq == pp;
            bool bb = ww == pp;
            bool aa1 = qq != pp;
            bool bb1 = ww != pp;
            Console.WriteLine($" {aa}, {bb}, {aa1}, {bb1}");
            Console.ReadLine();

            int qe = 7;
            int qr = 4;
            int qy = 5;
            bool qp = qe > qy;
            bool qo = qr > qy;
            bool qi = qe < qy;
            bool qu = qr < qy;
            Console.WriteLine($" {qp}, {qo}, {qi}, {qu}");
            Console.ReadLine();

            int qz = 4;
            int qa = 5;
            bool qs = qz != qa;
            bool qd = qz == qa;
            Console.WriteLine($" {qs}, {qd}");
            Console.ReadLine();

            int qm = 9;
            int qn = 7;
            bool qb = qm <= qn;
            bool qc = qm >= qn;
            Console.WriteLine($" {qb}, {qc}");
            Console.ReadLine();

            int aw = 134;
            int by = 46;
            bool rus = aw >= by;
            bool adr = aw <= by;
            Console.WriteLine($" {rus}, {adr}");
            Console.ReadLine();

            int bo = 32;
            int pu = 46;
            bool fbad = bo < pu;
            bool sth = bo > pu;
            Console.WriteLine($" {fbad}, {sth}");
            Console.ReadLine();




        }

        {
            // Task_8

            int m = 123;      
            object n = m;     // упаковка
            int v = (int)n;   // распаковка
            Console.WriteLine($" {m}, {n}, {v}");
            Console.ReadLine();
        }

        {
            // Task_9 явное

            double g = 569.2;
            int h;
            h = (int)g;
            Console.WriteLine(h);
            Console.ReadLine();
        }

        {
            // Task_9 неявное

            short k = 14;
            short t = 26;
            int zz = k + t;
            Console.WriteLine(zz);
            Console.ReadLine();

        }


        }
    }
