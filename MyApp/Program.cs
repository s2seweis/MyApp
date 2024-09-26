
// #######################################################

using MyApp.ToDoListProject;
using MyApp.Models;
using MyApp.Assignment;
using MyApp.ObjectOriented;
using MyApp.BankAccount;
using MyApp.List;

using MyApp.Dictionaries;

//With using you can include other namespaces

// #######################################################

namespace MyApp
// Namespace-Scope
 
{
    internal class Program
    // Class-Scope
    {

        static void Main(string[] args)
        //// Main method from which the program starts, scope limited to the class in which it was defined
        {


            // #######################################################
            //Dictionaries

            IndexEntryDictionary.CalculateIndexDictionary();


            // #######################################################
            // Assignment - List

            //IndexEntryAssignment.CalculateIndexAssignment();

            // #######################################################
            //Create List

            //IndexEntryThree.CalculateIndexThree();

            // #######################################################
            // Bank Account Project

            //IndexEntryTwo.CalculateIndexTwo();


            // #######################################################
            //Objektorientiertes Programmieren Teil1
            //Part1(Class = ObjectOrientedOne) + Part2(Method = CalculateObjectOrientedOne)

            //IndexEntry.CalculateIndex();

            //we create an instance of the car
            //Car myCar = new Car();
            //myCar.Honk();
            // Car is the class we defined elsewhere
            // myCar is the variable that hold the reference to the newly created Car object
            // new Car() creates a new object (an instance) of the class car by calling its constructor


            // #######################################################
            //Projects:

            //ToDoList.CalculateToDoList(); //works

            // #######################################################
            //Assignments:

            //AssignmentEmail.CalculateEmail();
            //WhileGamePro.WhileGameAdvaned();
            //WhileGame.WhileGameBeginner();
            //AssigmnetIf.CalculateAssignmentIf();

            // #######################################################
            //Models:

            //FloatCalculator.CalculateFloats();
            //StringCalculator.CalculateStrings();
            //VariableCalculator.CalculateVariables();
            //BoolCalculator.CalculateBool();
            //CharCalculator.CalculateChar();
            //Algorithm.CalculateAlgorithm();
            //Operators.CalculateOperators();
            //IfStatements.CalculateIfStatements();
            //NestedIfStatements.CalculateNestedIf();
            //NumberCollector.CollectNumbers();
            //DoWhile.CalculateDoWhile();
            //LoopCalculator.CalculateLoop();
            //ArrayCalculator.CalculateArray();
            //BreakpointCalculator.CalculateBreakPoint();
            //AgeCalculator.CalculateAge();


            //    Console.ReadKey(); // Wartet auf eine Taste, damit die Konsole offen bleibt
            Console.ReadKey();
           
        }
        
    }
}

        // Shortcuts:
        // end of the line semicolon, for command is over
        // beginning of the line: shift + 7
        // end of the line: shift + 1
        // move line up and down: alt + up/down
        // copy line strg + e after strg + v
        // delete line strg + x
        // Ctrl + K, then Ctrl + C (this will comment out the selected block)
        // Press Ctrl + K, then Ctrl + U (this will uncomment the selected block)
        // mark words: alt + shift + . (repeatedly)

        // Important:
        // Console.ReadLine(); 
        // Wartet auf eine Eingabe, damit die Konsole offen bleibt
        // Zoom in/out: strg + mouse rad
        // Clean Cache & Binary Files => right click on MyApp.sIn => "Erneut Erstellen"
        // Shortcuts hinzufügen: e.g => xml file erstellen  => mit .snippet Endung abspeichern => VS => Extras => Codeschnipsel Manager => C# => Importieren in MyCodeSnippets
        // return value string, when you slide over the method you see the return value string "strin?Console.readLine()"
        // Klasse hinzufügen => Rechts Klick auf den Projelt Ordner "MyApp" => "Hinzufügen" => "Neues Element hinzufügen" => 

        // Right click on MyApp => Ordner im Datei Explorer öffnen => bin => Debug => net8.0 => MyApp.exe (can be used to send somone the project)
        
        // Very Importand:
        //Ansicht => Fehlerliste => Shows erros like: Compile-Time Erros, Warnings, Messages, Build Erros, IntelliSense Erros, 
        // Unter den Fehlern muss eine Rote Linie sein

        //Longer Comments:
        /* 
         * 
         */