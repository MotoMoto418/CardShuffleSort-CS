using System;
using System.Linq;

namespace CardsShuffleSort
{
    class Program
    {
        public enum cardType
        {
            DiamondAce = 0,
            Diamond2 = 1,
            Diamond3 = 2,
            Diamond4 = 3,
            Diamond5 = 4,
            Diamond6 = 5,
            Diamond7 = 6,
            Diamond8 = 7,
            Diamond9 = 8,
            Diamond10 = 9,
            DiamondJ = 10,
            DiamondQ = 11,
            DiamondK = 12,
            HeartsAce = 13,
            Hearts2 = 14,
            Hearts3 = 15,
            Hearts4 = 16,
            Hearts5 = 17,
            Hearts6 = 18,
            Hearts7 = 19,
            Hearts8 = 20,
            Hearts9 = 21,
            Hearts10 = 22,
            HeartsJ = 23,
            HeartsQ = 24,
            HeartsK = 25,
            ClubsAce = 26,
            Clubs2 = 27,
            Clubs3 = 28,
            Clubs4 = 29,
            Clubs5 = 30,
            Clubs6 = 31,
            Clubs7 = 32,
            Clubs8 = 33,
            Clubs9 = 34,
            Clubs10 = 35,
            ClubsJ = 36,
            ClubsQ = 37,
            ClubsK = 38,
            SpadesAce = 39,
            Spades2 = 40,
            Spades3 = 41,
            Spades4 = 42,
            Spades5 = 43,
            Spades6 = 44,
            Spades7 = 45,
            Spades8 = 46,
            Spades9 = 47,
            Spades10 = 48,
            SpadesJ = 49,
            SpadesQ = 50,
            SpadesK = 51
        }
        static void Main(string[] args)
        {
            // Shuffle Algorithm
            var cards = Enumerable.Range(0, 52).ToArray();
            Random random = new Random();
            for (int i = 0; i<52; i++)
            {
                int num1 = random.Next(52);
                int num2 = random.Next(52);
                if (num1 != num2)
                {
                    int temp = cards[num1];
                    cards[num1] = cards[num2];
                    cards[num2] = temp;
                }
            }

            Console.WriteLine("The shuffled deck numbers are: ");
            foreach (int number in cards)
            {
                Console.Write(number + ",  ");
            }

            Console.WriteLine("\n The shuffled deck is: ");
            foreach (int card in cards)
            {
                Console.WriteLine((cardType)card);
            }

            // Insertion Sort

            int j = 1;
            while (j < cards.Length)
            {
                int k = j;
                while (k > 0 && cards[k -1] > cards[k])
                {
                    int temp2 = cards[k - 1];
                    cards[k - 1] = cards[k];
                    cards[k] = temp2;
                    k--;
                }
                j++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sorted deck numbers are: ");
            foreach (int number in cards)
            {
                Console.Write(number + ",  ");
            }

            Console.WriteLine("\n The sorted deck is: ");
            foreach (int card in cards)
            {
                Console.WriteLine((cardType)card);
            }
        }
        

        
        
    }

}
