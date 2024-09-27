
namespace MyApp.SwitchEnum
{
    internal class EnumProgram
    {
        public static void CalculateEnumProgram()
        {

            Console.WriteLine("Welche Aufl�sung w�hle Sie (720, 1920, 3840)?");

            int resolution = int.Parse(Console.ReadLine());

            // Die Zeile Resolutions myResolution = (Resolutions)resolution;
            // ist ein Type-Cast (Typumwandlung) in C#
            Resolutions myResolution = (Resolutions)resolution;
            // myResolution: Dies ist die Variable, die den Wert vom Typ Resolutions speichert.
            // Nach der Umwandlung enth�lt sie einen der Enum-Werte: SD, HD, oder UHD.

            // Zum Beispiel, wenn resolution den Wert 720 enth�lt,
            // wird dieser Wert in Resolutions.SD umgewandelt,
            // da der Enum-Eintrag SD den Wert 720 repr�sentiert.

            switch (myResolution)
            {
                case Resolutions.SD:
                    Console.WriteLine("Standard");
                    break;

                case Resolutions.HD:
                    Console.WriteLine("High Definition");
                    break;

                case Resolutions.UHD:
                    Console.WriteLine("Ultra High Definition");
                    break;
            }

        }
    }
}
