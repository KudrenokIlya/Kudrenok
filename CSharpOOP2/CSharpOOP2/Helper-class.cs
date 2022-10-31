using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public class Helper_class
    {
        public static void RepaintHorse(Horse horse, string newColor = "pink")
        {
            horse.Color = newColor;
        }

        public static void Parameteres(Horse horse)
        {
            
            Console.WriteLine($"Name of your horse is {horse.Name}");
            Console.WriteLine($"Color of your horse is {horse.Color}");
            Console.WriteLine($"Breed of your hourse is {horse.Breed}");
            Console.WriteLine($"Age is {horse.Age}");
            Console.ReadLine();
        }

        public static double HourseAgeByTailLength(Horse horse)
        {

            if (horse.TailLength > 0 && horse.TailLength <= 0.5)
            {
                return horse.Age = 1;
            }
            else if (horse.TailLength > 0.5 && horse.TailLength <= 1)
            {
                return horse.Age = 2;
            }
            else if (horse.TailLength > 1 && horse.TailLength <= 2)
            {
                return horse.Age = 3;
            }
            else
            {
                return horse.Age = 4;
            }
        }




    }
}
