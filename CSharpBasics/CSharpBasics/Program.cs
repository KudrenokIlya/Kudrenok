using System;
using System.Security.Cryptography;

class Homework
{
    static void Main()
    {
        //Task_1

        {
            int a = 8;
            Console.WriteLine(a);
            Console.ReadLine();

            double b = 6.353;
            Console.WriteLine(b);
            Console.ReadLine();

            char c = 'A';
            Console.WriteLine(c);
            Console.ReadLine();

            bool check = true;
            Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked
            Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
            Console.ReadLine();

            string str = "test";
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
                Console.ReadLine();
            }
        }
        

        //Task_2

        {
            int d = 3;
            int e = 3;
            bool f = d == e;
            bool g = d.Equals(e);
            Console.WriteLine($"Value for == is [{f}]");
            Console.WriteLine($"Value for Equals is [{g}]");
            Console.ReadLine();
        }

        //Task_3

        {
            string name = "Mike";
            string surname = "Ivanov";
            int age = 54;
            Console.WriteLine($"{name}, {surname}, {age}  ");

            Console.WriteLine("How old are you, - policeman asked.");
            Console.WriteLine("54, - Mike answered.");
            Console.ReadLine();
        }

        //Task_4

        {
            string s1 = "Moves";
            string s2 = "like";
            string s3 = "Jagger";
            Console.WriteLine($"{s1}");
            Console.WriteLine($"{s2}");
            Console.WriteLine($"{s3}");
            string[] values = new string[] {s1, s2, s3};
            string s4 = string.Join(" ", values);
            Console.WriteLine(s4);

            string s5 = s1 + s2 + s3;
            string s6 = string.Concat(s5); 
            Console.WriteLine(s6);
            Console.ReadLine();
        }

        //Task_5

        {
            string text = "Good day";
            text = text.Substring(2);
            Console.WriteLine(text);
            string a = "od day";
            a = a.Substring(3);
            Console.WriteLine(a);
            string b = "day";
            string[] values = new string[] {a, b};
            string c = string.Join(" ", values);
            Console.WriteLine(c);
            Console.ReadLine();
        }

        //Task_6

        {
            string text = "He had dark spectacles, puffy cheeks and a tell-me-my-good-man way talking,";
            Console.WriteLine(text);
            text = text.Replace("dark", "light");
            Console.WriteLine(text);
            Console.ReadLine();
        }

        //Task_7
        {
            Console.WriteLine("a" );
            Console.WriteLine("a".ToUpper());
            Console.ReadLine();
        }


    }




}


