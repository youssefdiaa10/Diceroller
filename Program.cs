namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Dice Game!");
            Console.WriteLine("You will roll a dice and compare the appearing number with the Opponent AI number.");

            int numRounds, plNum = 0, aiNum = 0, plScore = 0, aiScore = 0;
            bool flag;

            Random random = new();

            do
            {
                Console.WriteLine("Enter a number of Rounds:");
                flag = int.TryParse(Console.ReadLine(), out numRounds);
            } while (!flag);


            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");


            for (int i = 0; i < numRounds; i++)
            {
                Console.WriteLine("Press enter to roll the dice");

                Console.ReadKey();

                Console.WriteLine($"Round {i + 1}");

                plNum = random.Next(1, 7);
                Console.WriteLine($"Your rolled number: [{plNum}]");

                Console.WriteLine("...");
                Thread.Sleep(1000);

                aiNum = random.Next(1, 7);
                Console.WriteLine($"AI rolled number: [{aiNum}]");


                if (plNum > aiNum)
                {
                    plScore += 1;
                    Console.WriteLine("You win this Round!!!!");
                }
                else if (plNum < aiNum)
                {
                     aiScore += 1;
                    Console.WriteLine("You lose this Round!!!!");
                }
                else
                {
                    Console.WriteLine("Draw!!!!");
                }

                Console.WriteLine($"Score => (you: {plScore}) | (ai: {aiScore}).");

                Console.WriteLine("-------------------------------");
                Console.WriteLine();
            }


            if (plScore > aiScore)
            {
                Console.WriteLine("Congratulations You WIN the game.");
                Console.WriteLine("I am happy you've successed.");
            }
            else if (plScore < aiScore)
            {
                Console.WriteLine("Unfortunately You lose the game.");
                Console.WriteLine("Don't lose hope try again.");
            }
            else
            {
                Console.WriteLine("Draw.");
                Console.WriteLine("You were to close try again.");
            }


            Console.ReadKey();
        }
    }
}
