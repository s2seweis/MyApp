using System;
using System.IO; // Input/Output

namespace MyApp.FoldersAndPaths
{
    internal class IndexEntryFoldersAndPaths
    {
        public static void CalculateFoldersAndPaths()
        {
            string path = "test.txt";

            // CREATE File
            //File.Create(path);

            // Can crate any file type by it
            // Video 91: "Dateie erstellen und lesen/ 7:24", ausgeblendete Daten anzeigen lassen
            // Haken rausnehmen bei Erweiterungen bei bekannten Dateitypen

            // READ
            //string content = File.ReadAllText(path);
            //Console.WriteLine(content);

            // COPY File
            File.Copy();
            
        }
    }
}
