namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            var newRide = new Car();

            newRide.Make = "Jeep";

            newRide.Model = "Wrangler";

            newRide.Year = 2020;

            var Ford = new Car()
            {
                Make = "Ford",
                Model = "F150",
                Year = 2018

            };

            var carList = new List<Car> { newRide, Ford };

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
