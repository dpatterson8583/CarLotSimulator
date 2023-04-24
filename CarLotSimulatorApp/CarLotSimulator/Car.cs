using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() { }

        public Car(string make, string model, int year, string enoise, string hnoise, bool canDrive) 
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = enoise;
            HonkNoise = hnoise;
            IsDriveable = canDrive;
        
        }
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise) 
        {
            if (EngineNoise == "Loud")
            {
                Console.WriteLine("VROOOM VROOM!");
            } 
            else if(EngineNoise=="Moderate") {
                Console.WriteLine("Vroom Vroom.");
            }
            else 
            {
                Console.WriteLine("vroom.");
            }
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            if(HonkNoise=="Intimidating")
            {
                Console.WriteLine("HONK HONK!");
            }
            else if(HonkNoise=="Funny")
            {
                Console.WriteLine("Ring Ring");
            }
            else
            {
                Console.WriteLine("Beep Beep");
            }
        }
    }
}
