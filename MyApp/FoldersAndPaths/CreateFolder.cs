using System;
using System.IO; // Input/Output

namespace MyApp.FoldersAndPaths
{
	internal class CreateFolder
	{
		public static void CalculateCreateMethods()
		{

			string path = "files/";
			//string path = "C:\\Users\\SWE\\Desktop\\files";
			// Pfad zum Desktop
			//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/files";
			string fileName = "text.txt";

			if(Directory.Exists(path))
			{
				Console.WriteLine("Ordner existiert");
			}
            else
            {
				{
					Directory.CreateDirectory(path);
				}
            }

			// Get files
			var filesInDir = Directory.GetFiles(path);
			
			for (int i = 0; i < filesInDir.Length; i++)
			{
				Console.WriteLine(filesInDir[i]);
			}

			Console.WriteLine(filesInDir);
			
			// Get directories
			var dirsInDir = Directory.GetDirectories(path);
			
			for (int i = 0; i < dirsInDir.Length; i++)
			{
				Console.WriteLine(dirsInDir[i]);
			}

			var currentPath = Directory.GetCurrentDirectory();

			Console.WriteLine(currentPath);

			//Console.WriteLine(filesInDir);


        }
	}
}
