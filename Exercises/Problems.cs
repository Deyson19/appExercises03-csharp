namespace appExercises03.Exercises
{
    public static class Problems
    {
        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
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
    }
}
