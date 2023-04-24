using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot lot = new CarLot();

            var chevy = new Car();
            chevy.EngineNoise = "Moderaate";
            chevy.HonkNoise = "Intimidating";
            chevy.Model = "Corvette";
            chevy.Make = "Chevrolet";
            chevy.Year = 2022;
            chevy.IsDriveable = true;

           lot.carList.Add(chevy);

            var ford = new Car()
            {
                Year = 2023,
                Make = "Ford",
                Model = "Ranger",
                EngineNoise = "Loud",
                HonkNoise = "Funny",
                IsDriveable = true
            };

            lot.carList.Add (ford);

            var toyota = new Car("Toyota","Camry",1999,"Quiet","Medium",true);

            lot.carList.Add(toyota);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.carList)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Engine Noise: {car.EngineNoise}");
                Console.WriteLine($"Horn Noise: {car.HonkNoise}");
                Console.WriteLine($"Is it Driveable?: {car.IsDriveable}");
                Console.WriteLine("---------------------------------");
            }
            
        }
    }
}
