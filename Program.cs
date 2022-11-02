class NumberGuesser
{
    static void Main()
    {
        string name = GetName();
        int winningNumber = GetWinningNumber();
        Console.WriteLine(winningNumber);
        GetGuess(winningNumber, name);
    }

    static string GetName()
    {
        Console.WriteLine("What is your name?");

        string name = Console.ReadLine();

        return name;
    }

    static int GetWinningNumber()
    {
        Random rand = new Random();
        int winningNumber = rand.Next(1, 100);

        return winningNumber;
    }

    static void GetGuess(int winningNumber, string name)
    {
        Console.WriteLine($"Hello {name}. Please guess a number between 1 and 100!");

        int guess = -1;

        while (guess != winningNumber)
        {
            guess = Int32.Parse(Console.ReadLine());

            if (guess == winningNumber)
            {
                Console.WriteLine("Correct! Do you want to play again? [Y or N]");

                string response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    Random rand = new Random();
                    winningNumber = rand.Next(1, 100);

                    Console.WriteLine($"Hello {name}. Please guess a number between 1 and 100!");
                }
            }
            else if (guess < winningNumber)
            {
                Console.WriteLine("Too low! Guess again!");
            }
            else
            {
                Console.WriteLine("Too high! Guess again!");
            }
        }
    }
}