using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Player
    {
        BettingChoice bc = new BettingChoice();
        public int bets { get; set; }
        public static int money { get; set; }

        public static int wager { get; set; }

        public void SetUp(int bets, int points)
        {
            this.bets = bets;
            money = points;
        }
        //When the game starts, the player's info is initialized and they are thrown into a do while loop
        //which decriments the amount of bets remaining after every successful, or non-successful bet.
        //once the player runs out of bets they will be shown a game ending message based on their 
        //overall results. 
        public void StartGame()
        {
            Menu m = new Menu();
            SetUp(10, 100);
            m.MainScreen();
            do
            {
                Console.Clear();
                Console.WriteLine(" ╔═══════════════════════════════════╗");
                Console.WriteLine($"   Bets remaining: {bets} | Money ${money} ");
                Console.WriteLine(" ╚═══════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine("                                                      Choose your bet:");
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║  1. Numbers (35 to 1)| 2. Evens/Odds (2 to 1)| 3. Reds/Blacks (2 to 1)| 4. Lows/Highs (2 to 1)| 5. Dozens (3 to 1)  ║");
                Console.WriteLine("║  6. Columns (3 to 1) | 7. Street (12 to 1)   | 8. 6 Numbers (5 to 1)  | 9. Split (18 to 1)    | 10. Corner (8 to 1) ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.Write(":>");
                string bet = Console.ReadLine().ToString().ToLower();
                bc.Choice(bet);
                this.bets--;
            } while (bets > 0);

            EndGame();

        }

        public void EndGame()
        {
            Console.WriteLine($"You left the casino with ${money}");

            if (money < 100)
            {
                Console.WriteLine("You didn't even make any money! Try again later!");
                Console.ReadLine();
                StartGame();
            }
            else if (money >= 100 && money <= 500)
            {
                Console.WriteLine("Looks like you made some money! Try again and beat that score!");
                Console.ReadLine();
                StartGame();
            }
            else if (money > 501 && money <=1000)
            {
                Console.WriteLine("WOW! You really made out well! You must be a legendary LuckMaster(tm)");
                Console.ReadLine();
                StartGame();
            }
            else
            {
                Console.WriteLine("Okay, you made a suspiciously large amount of money... were you cheating?");
                Console.ReadLine();
                StartGame();
            }
        }

    }
}
