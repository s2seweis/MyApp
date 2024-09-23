using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ObjectOriented
{
    internal class Car
    //no access modifier => The elements are only accessible within the vehicle class
    //Classes are blueprints for creating objects
    //Better Code structure
    //DRY Principle = Dont Repeat Yourself)
    //Class is not the object, with classes we can define how an object should look like
    {
        //public string Brand { get; private set; }
        public string Brand { get; set; }

        //A variable is defined within the scope of a method
        //Create fields, following are fields =>

        //string brand = "toyota";

        public string Model { get; private set; } 
        public int Year { get; private set; }

        /*Best practise: Fields should not be changed from outside
        Therefore the fields should not be set to public
        we want read access but not write access /*

        /*#if you want create a method you use the keyword void, 
        void says that no return will be made from this method
        */


        //constructor, name of the class
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void Honk()
        //private void Honk()
            //"public" keyword makes the elemts availabe outside of the class 
            //"private" keyword for make the elements only accessible within the class
            //Parameter brackets
        {
            Console.WriteLine("Das Auto hupt!");
        }

        //return value needed
        public string GetFullInfo()
        {
            //string info = "Brand" + Brand + "Model" + Model + "Year" + Year;
            //return info;

            return $"{Brand}, {Model}, {Year}";
        }

        public float CalculateFuelConsumption(int kilometers, float consumptionRate)
        {
            float consumptionPerKm = consumptionRate/ 100;
            return kilometers * consumptionPerKm;
        }

    }
}
