Question[] questions = [
    new ("9 / 3", "3"),
    new ("4 * 9", "36"),
    new ("9 + 11", "20"),
    new ("5 - 4", "1"),
    new ("18 / 6", "3"),
    new ("14 + 15", "29"),
];
List<Answer> history = new(questions.Length);
int currentScore = 0;

Console.WriteLine("< Press [H] to view history, [Q] to exit >\n");
Console.WriteLine("Welcome to the Math Game. Let's begin.\n");

string answer = "";

foreach (var question in questions)
{
currentQuestion:
    Console.WriteLine($"What is the result of {question.Body}?\n");

    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

    switch (keyInfo.Key)
    {
        case ConsoleKey.H:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"\nCURRENT SCORE: {currentScore}\n");
            Console.WriteLine("HISTORY:\n");

            var counter = 1;

            for (int i = 0; i < history.Count; i++)
            {
                Console.Write($"{i + 1}. Question: \"{history[i].Question}\"? Answer: ");

                if (!history[i].AnsweredCorrectly)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write(history[i].AnsweredCorrectly + "\n");
                Console.ForegroundColor = ConsoleColor.Green;
                counter++;
            }

            Console.WriteLine("\n-----------------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Black;
            goto currentQuestion;

        case ConsoleKey.Q:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--- Exiting ---\n");
            Console.ForegroundColor = ConsoleColor.Black;

            Environment.Exit(0);
            break;

        default:
            Console.Write(keyInfo.KeyChar);
            var restOfTheAnswer = Console.ReadLine() ?? "";
            answer = keyInfo.KeyChar + restOfTheAnswer;
            break;
    }

    Console.WriteLine();

    if (answer == question.CorrectAnswer)
    {
        history.Add(new Answer(question.Body, true));
        currentScore++;
    }
    else
    {
        history.Add(new Answer(question.Body, false));
    }
}

Console.WriteLine($"\nFinal score: {currentScore}\n"); public readonly record struct Answer(string Question, bool AnsweredCorrectly);
public readonly record struct Question(string Body, string CorrectAnswer);