using System;
namespace CarLotSimulator
{
	public class Cars
	{
		public Cars()
		{
			CarLot.NumberOfCars++;
		}


        public Cars(string make, string model, string enginenoise, int year, bool isdrivable, string honknoise)
		{ 

            Year = year;
			Make = make;
			Model = model;
			EngineNoise = enginenoise;
			IsDrivable = isdrivable;
			HonkNoise = honknoise;
		}



        public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public bool IsDrivable { get; set; }
		public string HonkNoise { get; set; }



        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkeNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }

	



}

