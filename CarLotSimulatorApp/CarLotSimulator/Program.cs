using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            var lot = new CarLot();
            

            var POV = new Cars();
            POV.Make = "toyota";
            POV.Model = "Corolla";
            POV.Year = 2020;
            POV.IsDrivable = true;
            POV.HonkNoise = "Beep";
            lot.Cars.Add(POV);

            var WorkTruck = new Cars()
            {
                Make = "Toyota",
                Model = "Tundra",
                EngineNoise = "Loud",
                Year = 2023,
                IsDrivable = true,
                HonkNoise = "Hooonk",
            };
            lot.Cars.Add(WorkTruck);

            //(string make, string model, string enginenoise, int year, bool isdrivable, string honknoise)
            var RandomCar = new Cars("honda", "accord", "vroom", 2016, true,"beep");


            lot.Cars.Add(RandomCar);






            //done --- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //done ---- The methods should take one string parameter: the respective noise property
            RandomCar.MakeEngineNoise(RandomCar.EngineNoise);
            WorkTruck.MakeHonkeNoise(WorkTruck.HonkNoise);

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            //Done -  Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            

            foreach (var Car in lot.Cars)
            {
                Console.WriteLine($"Year: {Car.Year} \n Model: {Car.Model} \n Make: {Car.Make}");
            }
            Console.WriteLine($"the number of cars created is {CarLot.NumberOfCars}");


        }
    }
}
