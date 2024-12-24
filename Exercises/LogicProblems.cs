namespace appExercises03.Exercises
{
    public static class LogicProblems
    {

        public static string ReverseCase(string phrase)
        {
            //*https://edabit.com/challenge/99oN5igrbXddAjHEL
            /*
             * Given a string, create a function to reverse the case. 
             * All lower-cased letters should be upper-cased, and vice versa.
             */
            string result = string.Empty;
            Console.WriteLine($"Caracteres Iniciales: {phrase}");
            foreach (char item in phrase)
            {
                if (item.Equals(" "))
                {
                    result += " ";
                }
                if (Char.IsUpper(item))
                {
                    result += item.ToString().ToLower();
                }
                else
                {
                    result += item.ToString().ToUpper();
                }
            }

            return result;
        }
    }
}
