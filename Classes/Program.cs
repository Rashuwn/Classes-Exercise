namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Volkswagen";
            carOne.Model = "Jetta";
            carOne.Year = 2022;

            Console.WriteLine($"This is a {carOne.Make}, {carOne.Model}, made in the year {carOne.Year}.");
        }
    }
}
