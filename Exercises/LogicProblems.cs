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

        public static string FindBomb(string phrase)
        {
            /*
             * https://edabit.com/challenge/JYEufqRvkusjr5R58
             Create a function that finds the word in the given string (not case sensitive). 
               If found, return , otherwise, return ."bomb""Duck!!!""There is no bomb, relax."
             */

            if (phrase.ToLower().Contains("bomb"))
            {
                return "Duck!!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }

        public static string CountLetterAndDigits(string phrase)
        {
            /*
             https://edabit.com/challenge/ZSvj2W3J6QRydkyh2
            Write a function that takes a string and calculates the number of letters and digits within it. 
            Return the result as anonymous type in string format.
             */

            int digits = 0;
            int letters = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (Char.IsLetter(phrase[i]))
                {
                    letters++;
                }
                if (Char.IsDigit(phrase[i]))
                {
                    digits++;
                }
            }
            Console.WriteLine($"Cantidad letras: {letters}, cantidad digitos: {digits}");
            return new
            {
                LETTERS = letters,
                DIGITS = digits
            }.ToString();
        }
        
        public static void OneToHundred()
        {
            for (int i = 0; i <=100; i++)
            {
                Console.WriteLine($"Valor: {i}");
            }
        }
    }
}
