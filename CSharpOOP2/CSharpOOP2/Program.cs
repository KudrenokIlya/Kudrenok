using CSharpOOP2;


#region Task_4
Horse horse1 = new Horse();
horse1.Name = "Brayan";
horse1.Color = "Black";
horse1.Age = 3;
horse1.Breed = "Dutch Warmblood";
horse1.TailLength = 1.1;
horse1.IsVaccinated = true;
horse1.DaysNumberLastVaccination = 32;
#endregion

#region Task_5

Horse horse2 = new Horse() {Name = "Tom", Color = "White", Age = 2, Breed = "Shire", TailLength = 1.0, IsVaccinated = true, DaysNumberLastVaccination = 105};

#endregion

#region Task_9

Horse horseAllFields = new Horse("GEORGE", "Orange", 2.5, "Belgian", 0.8, true, 200);

#endregion

#region Task_10

bool result = horse1.NeedDoVactination(366);
horse1.Status(horse1.IsVaccinated);
Console.WriteLine(result);

#endregion

#region Task_11

// with internal modifier
horse2.CheckVaccination(horse2.Age);

// with private modifier
//horse2.CutTail(horse2.TailLength); Error Line

#endregion

#region Task_12
Horse horse3 = new Horse();
horse3.Name = "Mike";
horse3.Color = "Grey";
horse3.Age = 4;
horse3.Breed = "Dutch Warmblood";
horse3.TailLength = 2.5;
//horse3.IsVaccinated = true;
horse3.DaysNumberLastVaccination = 100;

horse3.Status(horse3.IsVaccinated);//this method is executed without error because the value is false
Console.WriteLine(result);
#endregion

#region Task_13

Horse horse4 = new Horse();
horse4.Color = "black";
Console.WriteLine(horse4.Color);

Console.ReadLine();
#endregion

#region Task_15
Horse horsecheck = new Horse();
horsecheck.Speed = 15;
//Console.WriteLine(horsecheck.Speed); //Error Line

//horsecheck.IsReadyToCompetition = true; //Error Line
Console.WriteLine("This horse can take part in competition");

Console.ReadLine();
#endregion

#region Task_17
Console.WriteLine("Use static property");

Console.WriteLine($"Our animal is {Horse.Kind}");
Horse.Kind = "New Horse";
Console.WriteLine($"Now we change animal to {Horse.Kind}");

Console.ReadLine();
#endregion

#region Task_18
Console.WriteLine("Enter number of horses");
int numberofhorses = int.Parse(Console.ReadLine());

Console.WriteLine(Horse.Numberofhorses(numberofhorses));
Console.ReadLine();
#endregion

#region Task_20
Helper_class.RepaintHorse(horse3);


Console.WriteLine($"Age is {horse1.Age}");


Console.WriteLine($"Age of horse is {Helper_class.HourseAgeByTailLength(horse2)}");

#endregion
