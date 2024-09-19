namespace MyApp
{
    internal class LoopCalculator
    {
        public static void CalculateLoop()
        {
            //Loops

            int[] numbers1 = new[] { 50, 200, 75 };

            //Foreach Loop

            int result1 = 0;

            foreach
                (int number in numbers1)
            {
                result1 += number;
                // outside of the foreach loop we define the variable
            }

            /*result: Eine Variable, die wahrscheinlich schon einen Wert enthält.
             * number: Die Variable, deren Wert zu result addiert wird.
             * +=: Das Zuweisungsoperator += addiert den Wert rechts vom Operator (number) 
             * zum aktuellen Wert der linken Variable (result), 
             * und das Ergebnis wird in der linken Variable gespeichert.
             */

            Console.WriteLine(result1);

            string[] names = new string[3] { "Jannick", "Maria", "Karl" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //For Loop

            int[] numbers2 = new int[] { 50, 200, 75 };



            //3 configurations: running variable,
            //the condition how long the loop should run,
            //i will be increased by 1 each time

            // we use for loop to iterate through a collection to read the the array 

            int result2 = 0;

            for (int i = 0; i < numbers2.Length; i++)
            {
                result2 += numbers2[i];
            }

            Console.WriteLine(result2);


            // counts 1 to 10 
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            int maxNumber = 100;

            // all straight numbers up to 20
            // initialize +2

            //for (int i = 2; i <= 20; i+=2)
            for (int i = 2; i <= maxNumber; i+=2)
            {
                Console.WriteLine(i);
            }

            //count backwards

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            //While Loop

            // from top to bottom the code will be executed,
            // when the condition is correct
            // the code will be executed again in a while loop
            // as long the condition is true the code will be executed
            // often the while loop will be used to control the program flow, the while loop will start again and look after the next condition

            int i2 = 0;

            while (i2 < 10)
            {
                Console.WriteLine(i2);
                i2++;
                //i2+=2;
            }

            //############################################

            int[] numbers3 = new int[3] { 5, 10, -3 };

            int i3 = 0;

            while (i3 < numbers3.Length)
            {
                Console.WriteLine(numbers3[i3]);
                i3++;
                //i2+=2;
            }

        }
    }
}