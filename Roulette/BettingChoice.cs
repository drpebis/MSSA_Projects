using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Roulette.Player;
using static Roulette.WheelArray;

namespace Roulette
{
    class BettingChoice
    {
        WheelArray wa = new WheelArray();
        WheelSpin ws = new WheelSpin();
        public int binChoice { get; set; }

        //This method takes the string from the player class and routes the player's chosen bet through it's proper course.
        public void Choice(string menu)
        {
            try
            {
                switch (menu)
                {
                    case "1":
                        //Straight number bet
                        Console.WriteLine("What number to you want to bet on? ");
                        Console.Write(":>");
                        NumCheck();
                        Bet();
                        int resultI = wa.GetBallPosition(wa.wheelAll);
                        string resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Number();
                        Console.ReadLine();
                        break;
                    case "2":
                        //Even or odd bet
                        Console.WriteLine("1. Evens | 2. Odds?");
                        Console.Write(":>");
                        int evenOdd = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        EvenOdd(evenOdd);
                        Console.ReadLine();
                        break;
                    case "3":
                        //red or black bet
                        Console.WriteLine("1.Reds | 2. Blacks");
                        Console.Write(":>");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        RedBlack(choice, resultC);
                        Console.ReadLine();
                        break;
                    case "4":
                        //low or high bet
                        Console.WriteLine("1. Lows | 2. Highs");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        LowHigh(choice);
                        Console.ReadLine();
                        break;
                    case "5":
                        //dozen bet
                        Console.WriteLine("Which Dozen?\n1. 1 - 12 | 2. 13 - 24 | 3. 25 - 36");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Dozen(choice);
                        Console.ReadLine();
                        break;
                    case "6":
                        //column bet
                        Console.WriteLine("Which Column?\n1. | 2. | 3. ");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Column(choice);
                        Console.ReadLine();
                        break;
                    case "7":
                        //street bet
                        Console.WriteLine("Which Street?\n1 - 12");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Street(choice);
                        Console.ReadLine();
                        break;
                    case "8":
                        //6's bet
                        Console.WriteLine("Which 6?\n1 - 6");
                        Console.Write(":>");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Double6(choice);
                        Console.ReadLine();
                        break;
                    case "9":
                        //split bet, how the betting table is set up, each number is either +1, -1, +4, or -4
                        //away from the user's first bet, so this checks for that condition before the bet is valid
                        Console.WriteLine("Enter your first number, then press enter:");
                        Console.Write(":>");
                        int choicea, choiceb;
                        choicea = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your second number, then press enter:");
                        Console.Write(":>");
                        do
                        {
                            choiceb = Convert.ToInt32(Console.ReadLine());
                        } while (choicea != choiceb + 1 && choicea != choiceb - 1 && choicea != choiceb + 3 && choicea != choiceb - 3);
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Split(choicea, choiceb);
                        Console.ReadLine();
                        break;
                    case "10":
                        //corner bet, this asks for the smallest value in the user's bet, the bet cannot be divisible by 3
                        Console.WriteLine("What is the lowest value in your corner bet?");
                        int corner;
                        do
                        {
                            Console.Write(":>");
                            corner = Convert.ToInt32(Console.ReadLine());
                        } while (corner < 1 && corner > 36);
                        Bet();
                        resultI = wa.GetBallPosition(wa.wheelAll);
                        resultC = wa.GetBallColor(wa.color);
                        ws.Spin();
                        Console.WriteLine($"The ball landed in {resultC} {resultI}.");
                        Corner(corner);
                        Console.ReadLine();
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        //This method checks to see if the player has enough money to bet
        public void Bet()
        {
            try
            {
                Player p = new Player();
                Console.WriteLine("How much do you bet?");
                Console.Write(":>");
                Player.wager = Convert.ToInt32(Console.ReadLine());
                while (Player.wager > Player.money)
                {
                    Console.WriteLine("You're trying to bet more than what you have!");
                    Console.WriteLine("Try again:");
                    Console.Write(":>");
                    Player.wager = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        //Corner bet, by adding +1, +2, and +1 to the smallest value, this will make the corner valid
        public void Corner(int corner1)
        {
            int corner2, corner3, corner4;
            if (corner1 % 3 != 0)
            {
                corner2 = corner1 + 1;
                corner3 = corner2 + 2;
                corner4 = corner3 + 1;
            }
            else
            {
                corner2 = corner1 - 1;
                corner3 = corner1 + 3;
                corner4 = corner3 - 1;
            }
            if (corner1 == wa.ballPosition || corner2 == wa.ballPosition || corner3 == wa.ballPosition || corner4 == wa.ballPosition)
            {
                Player.money += ((Player.wager * 8) - Player.wager);
                Console.WriteLine($"You won ${Player.wager * 8}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                PlayerLost();
            }
        }
        //Split bet only works if the players second bet is +1, -1, +4, or -4 from the first bet
        public void Split(int choicea, int choiceb)
        {
            if (choicea == wa.ballPosition || choiceb == wa.ballPosition)
            {
                Player.money += ((Player.wager * 18) - Player.wager);
                Console.WriteLine($"You won ${Player.wager * 18}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                PlayerLost();
            }
        }
        //6's bet splits the board into 6, 5 to 1 odds
        public void Double6(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (choice == 1 && wa.ballPosition <= 6)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    if (choice == 2 && wa.ballPosition >= 7 && wa.ballPosition <= 12)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 3:
                    if (choice == 3 && wa.ballPosition >= 13 && wa.ballPosition <= 18)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 4:
                    if (choice == 4 && wa.ballPosition >= 19 && wa.ballPosition <= 24)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 5:
                    if (choice == 5 && wa.ballPosition >= 25 && wa.ballPosition <= 30)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 6:
                    if (choice == 6 && wa.ballPosition >= 31 && wa.ballPosition <= 36)
                    {
                        Player.money += ((Player.wager * 6) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 5}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
            }
        }
        //splits the board into threes, vertically
        public void Street(int choice)
        {
            switch (choice)
            {
                case 1:
                    bool column = wa.InColumn(wa.street1);
                    if (choice == 1 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    column = wa.InColumn(wa.street2);
                    if (choice == 2 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 3:
                    column = wa.InColumn(wa.street3);
                    if (choice == 3 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 4:
                    column = wa.InColumn(wa.street4);
                    if (choice == 4 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 5:
                    column = wa.InColumn(wa.street5);
                    if (choice == 5 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 6:
                    column = wa.InColumn(wa.street6);
                    if (choice == 6 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 7:
                    column = wa.InColumn(wa.street7);
                    if (choice == 7 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 8:
                    column = wa.InColumn(wa.street8);
                    if (choice == 8 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 9:
                    column = wa.InColumn(wa.street9);
                    if (choice == 9 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 10:
                    column = wa.InColumn(wa.street10);
                    if (choice == 10 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 11:
                    column = wa.InColumn(wa.street11);
                    if (choice == 11 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 12:
                    column = wa.InColumn(wa.street12);
                    if (choice == 12 && column == true)
                    {
                        Player.money += ((Player.wager * 11) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 11}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
            }
        }
        //splits the board into three horizontal columns, unlike the street and 6's bet, I chose to have
        //this method check via another array vs just writing in the valid numbers. This way I got 
        //practice using boolean methods and checking values within arrays.
        public void Column(int choice)
        {
            switch (choice)
            {
                case 1:
                    bool column = wa.InColumn(wa.column1);
                    if (choice == 1 && column == true)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    column = wa.InColumn(wa.column2);
                    if (choice == 2 && column == true)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 3:
                    column = wa.InColumn(wa.column3);
                    if (choice == 3 && column == true)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
            }
        }
        //splits the board into chunks of 12
        public void Dozen(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (wa.ballPosition <= 12)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    if (wa.ballPosition >= 13 && wa.ballPosition <= 24)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 3:
                    if (wa.ballPosition >= 25 && wa.ballPosition <= 36)
                    {
                        Player.money += ((Player.wager * 3) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 3}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
            }
        }
        //Checks if the ball is 18 or below 
        public void LowHigh(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (wa.ballPosition <= 18)
                    {
                        Player.money += ((Player.wager * 2) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    if (wa.ballPosition >= 19)
                    {
                        Player.money += ((Player.wager * 2) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;

            }
        }
        //Checks if the color is red or black
        public void RedBlack(int choice, string resultC)
        {
            if (choice == 1 && resultC == "Red")
            {
                Player.money += ((Player.wager * 2) - Player.wager);
                Console.WriteLine($"You won ${Player.wager * 2}!");
                Console.WriteLine("Press enter...");
            }
            else if (choice == 2 && resultC == "Black")
            {
                Player.money += ((Player.wager * 2) - Player.wager);
                Console.WriteLine($"You won ${Player.wager * 2}!");
                Console.WriteLine("Press enter...");
            }
            else
            {
                PlayerLost();
            }

        }
        //checks if the ball landed in an even or odd bin
        public void EvenOdd(int evenOdd)
        {
            BettingChoice bc = new BettingChoice();
            switch (evenOdd)
            {
                case 1:
                    if (wa.ballPosition % 2 == 0)
                    {
                        Player.money += ((Player.wager * 2) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
                case 2:
                    if (wa.ballPosition % 2 != 0)
                    {
                        Player.money += ((Player.wager * 2) - Player.wager);
                        Console.WriteLine($"You won ${Player.wager * 2}!");
                        Console.WriteLine("Press enter...");
                    }
                    else
                    {
                        PlayerLost();
                    }
                    break;
            }
        }
        //This method occurs every time the player loses, it takes out the wagered amount from the player's
        //money and checks if they have enough money to keep playing.
        public void PlayerLost()
        {
            Player p = new Player();
            Player.money -= Player.wager;
            Console.WriteLine($"You lost, you now have ${Player.money} left.");
            Console.WriteLine("Press enter...");
            if (Player.money <= 0)
            {
                Console.WriteLine("You've run out of cash!\nTry again...");
                Console.ReadLine();
                p.StartGame();
            }
        }
        //number bet, checks if the specific number the player is betting on gets called
        public void Number()
        {
            Player p = new Player();
            BettingChoice b = new BettingChoice();
            if (b.binChoice == wa.ballPosition)
            {
                Player.money += (Player.wager * 35);
                Console.WriteLine($"You won ${Player.wager * 35}!");
            }
            else
            {
                PlayerLost();
            }

        }
        //validates the players choice in the number bet, I only use this method once, it was 
        //practice to pass values around. 
        public int NumCheck()
        {
            int binChoice;
            do
            {
                string choice = (Console.ReadLine().ToString().ToLower());
                if (choice == "0")
                {
                    binChoice = 36;
                }
                else if (choice == "00")
                {
                    binChoice = 37;
                }
                binChoice = Convert.ToInt32(choice);
                binChoice++;
            } while (binChoice < 1 || binChoice > 38);

            return binChoice;
        }

    }
}
