using System;

class Homework_2
{
    static void Main()
    {
        //Task1
        {
            int enterNumber = Convert.ToInt32(Console.ReadLine());

            if (enterNumber % 2 == 0 && enterNumber % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }

            else if (enterNumber % 5 == 0)
            {
                Console.WriteLine("frutti");
            }

            else if (enterNumber % 2 == 0)

            {
                Console.WriteLine("tutti");
            }

            Console.ReadLine();
        }

        //Task2
        {
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            for (int i = firstnumber; i <= secondnumber; i++)
            {

                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("tutti-frutti");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("frutti");
                }

                else if (i % 2 == 0)
                {
                    Console.WriteLine("tutti");
                }

                else
                {
                    Console.WriteLine("Сan’t be delived on 2 or 5");
                }

                Console.ReadLine();


            }

            //Task3
            {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"{firstNumber} is bigger");
                }
                else if (secondNumber > firstNumber)
                {
                    Console.WriteLine($"{secondNumber} is bigger");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

            }
    }
}
}
