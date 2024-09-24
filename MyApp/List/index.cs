using System;
using System.Collections.Generic; // Füge diesen Namespace hinzu

namespace MyApp.List
{
    internal class IndexEntryThree
    {
        public static void CalculateIndexThree()
        {

            // Liste der Studenten erstellen
            // import from students.cs => defined as class there
            List<StudentList> students = new List<StudentList>
            {
                new StudentList(1, "John", 3.5f),
                new StudentList(2, "Jane", 3.8f),
                new StudentList(3, "Mark", 3.2f)
            };


            // #######################################################

            // 1. Studenteninformationen anzeigen
            Console.WriteLine("Liste der Studenten:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, GPA: {student.GradePointAverage}");
            }

            // #######################################################

            // 2. Durchschnittlichen NC (Grade Point Average) berechnen
            float totalGPA = 0;
            foreach (var student in students)
            {
                totalGPA += student.GradePointAverage;
            }

            float averageGPA = totalGPA / students.Count;

            // 3. Durchschnittlicher NC ausgeben
            Console.WriteLine($"Der durchschnittliche NC der Studenten ist: {averageGPA}");

        
        }

    }
    

}
