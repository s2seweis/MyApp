using System;
using System.IO; // Input/Output

namespace MyApp.FoldersAndPaths
{
    internal class Methods
    {
        public static void CalculateMethods()
        {
            //need first to creat a folder called:"files"
            //string path = "files/text.txt";

            string path = "text.txt";

            //CREATE File
            File.Create(path);

            // CREATE File
            //File.Create(path);

            // Can crate any file type by it
            // Video 91: "Dateie erstellen und lesen/ 7:24", ausgeblendete Daten anzeigen lassen
            // Haken rausnehmen bei Erweiterungen bei bekannten Dateitypen

            // READ
            //string content = File.ReadAllText(path);
            //Console.WriteLine(content);

            // COPY File
            //if (File.Exists(path) == true)
            //{
            //    string desPath = "text2.txt";
            //        File.Copy(path, desPath);
            //} else
            //{
            //    Console.WriteLine("Can not find file");

            //    FileStream fs = File.Create(path);

            //    fs.Close();

            //    Console.WriteLine("Created file");
            //    File.WriteAllText(path, "Hallo Sebastian");
            //}

            ////APPEND
            //if(File.Exists(path) == true)
            //{
            //    File.AppendAllText(path, "1234");
            //}

            // Delete
            //if (File.Exists(path) == true)
            //{
            //    File.Delete(path);
            //}

        }
    }
}
