using System;
using System.Collections.Generic; // Füge diesen Namespace hinzu

namespace MyApp.Assignment
{
    internal class IndexEntryAssignment
    {
        public static void CalculateIndexAssignment()
        {

            MyApp.Assignment.List myList = new MyApp.Assignment.List();

            myList.AddNumber(5);
            myList.AddNumber(10);
            myList.AddNumber(15);

            float average = myList.CalculateAverage();
            Console.WriteLine($"Der Durchschnitt ist: {average}");

        }

    }


}
