using System.Drawing;

namespace appExercises03.Exercises
{
    public static class Problems
    {
        private static void PrintMessage(string message)
        {
            Console.WriteLine($"El resultado es: { message}");
        }
        public static void FahrenheitToCelsius(int temperature)
        {
            //*5/9 => 0.55555...
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine($"La temperatura final en Celsius es: {celsius}");
        }
        public static void CelsiusToFa(int temperature)
        {
            var result = (temperature * 1.8) + 32;
            PrintMessage($"El resultado es: {result}");
        }

        public static void KelvinToCelsius(int temperature)
        {
            var result = temperature - 273.15;
            PrintMessage($"El resultado es: {result}");
        }
        

        //* Distance
        public static void MetersToKilometers(double distance)
        {
            double result = distance / 1000;
            PrintMessage(result.ToString());
        }
        public static void KilometersToMeters(double distance)
        {
            double result = distance * 1000;
            PrintMessage(result.ToString());
        }

        //* Geometry
        public static void SquareArea(double side1, double side2)
        {
            double result = side1 * side2;
            PrintMessage(result.ToString()+"^2");
        }
        public static void RectangleArea(double width, double height)
        {
            double result = width * height;
            PrintMessage(result.ToString() );
        }
    }
}
