using System;

namespace TrueOrFalseCLI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Type your code below

            string[] questions = new string[]
            {
        "My name is Beth",
        "Beth is 43 years old",
        "Macaroon fights with his foot"
            };

            bool[] answers = new bool[]
            {
        true,
        false,
        true
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning: The number of answers supplied does not match the number of questions.");
            }

            int askingIndex = 0;
            foreach (string q in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(q);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex += 1;

            }
            int scoringIndex = 0;
            int score = 0;
            foreach (bool ans in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input: {response} | Answer: {ans}");

                if (response == ans)
                {
                    score += 1;
                }

                scoringIndex += 1;
            }

            Console.WriteLine($"You scored {score} out of {answers.Length} correct.");
            Console.WriteLine("GAME OVER, MAN!");

        }
    }
}
