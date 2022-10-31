using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public class Horse
    {
        public string Name;
        public string Color;
        public double Age;
        public string Breed;
        public double TailLength;
        public bool IsVaccinated;
        public int DaysNumberLastVaccination;
        public int _speed;
        public bool _isReadyToCompetition;
        public static string _kind;
        public int horseNumber;

        //TASK_3
        public bool NeedDoVactination(int DaysNumberLastVactination)
        {
            if (DaysNumberLastVactination >= 0 && DaysNumberLastVactination <= 365)
            {
                return IsVaccinated = true;
            }
            else
            {
                return IsVaccinated = false;
            }
        }

        //TASK_6
        public Horse(string name, string color, double age, string breed, double tailLength, bool isVaccinated, int daysNumberLastVaccination)
        {
            Name = name;
            Color = color;
            Age = age;
            Breed = breed;
            TailLength = tailLength;
            IsVaccinated = isVaccinated;
            DaysNumberLastVaccination = daysNumberLastVaccination;
        }

        //TASK_7

        public Horse()
        {
        }

        //TASK_8
        public Horse(string name, string color)
        {
            Name = name;
            Color = color;
        }

        //TASK_10
        public void Status(bool isVactinated)
        {
            if (IsVaccinated)
            {
                Console.WriteLine("horse vactinated");
            }
            else
            {
                Console.WriteLine("horse not vactinated");
            }
        }

        //TASK_11
        internal void CheckVaccination(double age)
        {
            switch (Age)
            {
                case 0:
                    Console.WriteLine("First vactination is required.");
                    break;
                case 1:
                    Console.WriteLine("Second vactination is required.");
                    break;
                case 2:
                    Console.WriteLine("Third vactination is required.");
                    break;
                case 3:
                    Console.WriteLine("Fourth vactination is required.");
                    break;
                default:
                    Console.WriteLine("Vactination at the request of the owner");
                    break;
            }
        }


        private string CutTail(double tailLength)
        {
            if (tailLength < 0.5)
            {
                return $"Value {tailLength} is not correct";
            }
            else if (tailLength > 0.5 && tailLength <= 1.3)
            {
                return $"Your horse with tail {tailLength} look perfect and ready for exibition.";
            }
            else
            {
                return $"The horse with {tailLength} should go to a haidresser for animals.";
            }
        }

        //TASK_14
        public int Speed
        {
            set { _speed = value; }
        }

        public bool IsReadyToCompetition
        {
            get { return _isReadyToCompetition; }
        }

        //TASK_16
        public static string Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

        //TASK_18
        public static string Numberofhorses(int horseNumber)
        {
            switch (horseNumber)
            {
                case 0:
                    return "This count is not enough for competition";
               
                default:
                    return "This count is enough for competition";
            }

        }








    }

}
    
