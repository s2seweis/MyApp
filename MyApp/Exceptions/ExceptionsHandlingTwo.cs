
using System.Security.Cryptography.X509Certificates;

namespace MyApp.Exceptions
{
    internal class ExceptionsHandlingTwo
    {
       
        public static void CalculateExceptionsTwo()

        {

            string logPath = "log.txt";
            string fileName = "test.txt";
            string path = "folder/folder2/"; //invalid

            try
            {
            
            string finalPath = Path.Combine(path + fileName);
            File.Create(finalPath);
            File.AppendAllText(finalPath, "Hallo Welt");
            File.AppendAllText(logPath, "Log: Successfully created file. \n");
            
            }
            //catch (IOException e)  
            //{
            //    File.AppendAllText(logPath, "Log: File already in use." + e + "\n");
            //}
            catch (Exception e)
            {
                //Directory.CreateDirectory(path);
                //File.AppendAllText(logPath, "Log: Something went wrond during file creation: Exception:" + e + "\n");
                throw;
                // Das Programm schließt sich selber
            }


            //File.AppendAllText(logPath, "Log: Tried to create file. \n");

            Console.WriteLine("Nicht ausgeführt");

        }
    }
}
