using System;

class CoinTossingTest
{
    static void Main()
    {
        CoinTossing coinTossing = new CoinTossing();

        Random randomNumbers = new Random();

        int heads = 0;
        int tails = 0;

        Console.Write("\n\t\t>>>>>>>>>>> Welcome to the Coin Tossing <<<<<<<<<<<\n\n\n");
        Console.Write("Please enter how many times you'd like to toss the coin: ");
        int coinTossingtheTossing = int.Parse(Console.ReadLine());
        coinTossing.SetTossing(coinTossingtheTossing);

        for (int toss = 1; toss <= coinTossingtheTossing; ++toss)
        {
            int face = randomNumbers.Next(1, 3);

            switch (face)
            {
                case 1:
                    ++heads;
                    break;
                case 2:
                    ++tails;
                    break;
            }
        }

        Console.Write($"\n\nNumber of heads: {heads}.");
        Console.WriteLine($"\nNumber of tails: {tails}.");

    }
}

