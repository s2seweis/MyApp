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
        //A variable is defined within the scope of a method
        //Create fields, following are fields =>
        string brand = "Toyota";
        string model = "Fortuner";
        int year = 2004;

        /*#if you want create a method you use the keyword void, 
        void says that no return will be made from this method
        */
        public void Honk()
        //private void Honk()
            //"public" keyword makes the elemts availabe outside of the class 
            //"private" keyword for make the elements only accessible within the class
            //Parameter brackets
        {

            Console.WriteLine("Das Auto hupt!");
        }
    }
}
