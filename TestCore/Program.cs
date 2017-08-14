using System;
using System.Collections.Generic;
using System.IO;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string vStrFormat = "This vehicle : {0}, has {1} wheels";

            Vehicle v = new Vehicle("test",2);

            List<Vehicle> listOfVehicles = new List<Vehicle>();

            listOfVehicles.Add(v);

            foreach (Vehicle vi in listOfVehicles){
                Console.WriteLine((string.Format(vStrFormat,vi.Description,vi.WheelCount)));
            }

            int fibNum = 5;

            for (int i = 0; i < fibNum; i++)
            {
                Console.WriteLine("#" + PrintFib((i)));
            }


            Console.WriteLine();

            Console.ReadLine();

        }

        static int PrintFib(int count){

            if(count== 0)
            {
                return 0;
            }
            if(count == 1 ){
                return 1;
            }
            else{
                int result = PrintFib(count - 1) + PrintFib(count - 2);
                return result;
            }
        }

    }

    public class Vehicle {

        public Vehicle(string description, int wheels){
            this.WheelCount = wheels;
            this.Description = description;
        }

        public int WheelCount { get; set; }
        public string Description { get; set; }

    }
}
