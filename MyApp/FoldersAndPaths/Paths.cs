using System;
using System.IO; // Input/Output

namespace MyApp.FoldersAndPaths
{
    internal class Paths
    {
        public static void CalculatePaths()
        {

            //string path = "/files";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/files";
            string path = "C:\\Users\\SWE\\Desktop\\files";
            //string fileName = "text.txt";

            //string finalPath = Path.Combine(path, fileName);
            // Gibt einen gültigen Ordner Pfad zurück, um as Einzelstücken einen gültigen Pfad zusammenzubauen

            //Console.WriteLine(finalPath);
            //Console.WriteLine(path + "\\" + fileName);

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                //Console.WriteLine(files[i]);
                //var ext = Path.GetExtension(files[i]);
                // Um heraus zu bekommen die Datei Endung oder den Datei Namen ohne die Datei Endung
                var ext = Path.GetFileNameWithoutExtension(files[i]);

                Console.WriteLine(ext);
            }

        }
    }


}
