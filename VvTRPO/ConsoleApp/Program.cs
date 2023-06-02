using static ProgramLib.Library;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter neccessary parameters:");
            Console.Write("truncated cone height = ");
            var heightS =  Console.ReadLine().Replace('.', ',');
            Console.Write("truncated cone small radius = ");
            var smallRadiusS =  Console.ReadLine().Replace('.', ',');
            Console.Write("truncated cone big radius = ");
            var bigRadiusS =  Console.ReadLine().Replace('.', ',');

            if (double.TryParse(heightS, out var height) &&
                double.TryParse(smallRadiusS, out var smallRadius) && 
                double.TryParse(bigRadiusS, out var bigRadius) &&
                height > 0 && smallRadius > 0 && bigRadius > 0
                )
            {
                var volume = Math.Round(TruncatedConeVolume(height, smallRadius, bigRadius), 3);
                Console.WriteLine($"Truncated cone volume is {volume}");
                return;
            }

            Console.WriteLine("Incorrect input, please try again");
        }
    }
}