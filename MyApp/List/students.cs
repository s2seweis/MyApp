using System;
using System.Collections.Generic; // F�ge diesen Namespace hinzu

namespace MyApp.List
{
    internal class StudentList
    {
        // Eigenschaften der Klasse
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float GradePointAverage { get; private set; }

        // Konstruktor
        public StudentList(int id, string name, float gradePointAverage)
        {
            Id = id;
            Name = name;
            GradePointAverage = gradePointAverage;
        }
    }

    
}


// Aufgabe: Erstelle ein Programm mit einer Liste von Studenten
// Verwende f�r den Studenten eine Klasse
// Jeder Student hat einen NC
// Berechne dann den durchschnittlichen NC aller Studenten mit einer Schleife

