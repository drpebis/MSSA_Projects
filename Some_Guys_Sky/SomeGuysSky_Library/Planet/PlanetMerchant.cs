using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SomeGuysSky_Library.Enums;

namespace SomeGuysSky_Library
{
    class PlanetMerchant
    {


        public MerchantAction GetMechantAction(int Money)
        {
            const int buyAction = (int)MerchantAction.Buy;
            const int sellAction = (int)MerchantAction.Sell;
            const int exitAction = (int)MerchantAction.Exit;

            var selectionText = $"{Environment.NewLine}{buyAction} - Buy{Environment.NewLine}{sellAction} - Sell{Environment.NewLine}{exitAction} - Exit";

            var menuText = $"Welcome to the Planet Merchant! {Environment.NewLine} What would you like to do?";
            menuText += selectionText;

            var moneyText = $"{Environment.NewLine} Current Money: {Money}{Environment.NewLine}";

            var builder = new StringBuilder();
            var dashes = builder.Append('-', moneyText.Trim().Length + 2).ToString();

            WriteText.WriteLine($"{dashes}{moneyText}{dashes}");
            WriteText.WriteLine(menuText);
            Console.ReadLine();
            Console.Clear();

            var enteredText = Console.ReadLine()?.Trim();

            while (!IsValidMenuSelection(enteredText, 1, 3))
            {
                Console.WriteLine("Please attempt your selection again.");
                Console.WriteLine(selectionText);
                enteredText = Console.ReadLine()?.Trim();
            }

            var menuActionString = int.Parse(enteredText);
            return (MerchantAction)menuActionString;
        }

        public PlanetMenu GetItemToSell(List<Items> itemsToSell)
        {
            return GetMenuReturnItemForAction(MerchantAction.Sell, itemsToSell);
        }

        public PlanetMenu GetItemToBuy(List<Items> itemsToBuy)
        {
            return GetMenuReturnItemForAction(MerchantAction.Buy, itemsToBuy);
        }
        PlanetGenerator P = new PlanetGenerator();
        private PlanetMenu GetMenuReturnItemForAction(MerchantAction actionToPerform, List<Items> menuItems)
        {
            var maxItemNumber = menuItems.Count;
            var backMenu = maxItemNumber + 1;
            WriteText.WriteLine(P.PlanetType());
            var textOption = actionToPerform == MerchantAction.Buy ? "buy" : "sell";
            var displayText = $"Please choose an item to {textOption}:";

            var itemDictionary = new Dictionary<int, Items>();

            for (var num = 0; num < maxItemNumber; num++)
            {
                var item = menuItems[num];
                var itemNumber = num + 1;

                itemDictionary.Add(itemNumber, item);
                var itemAmount = actionToPerform == MerchantAction.Buy ? item.Price : item.GetSellValue();
                displayText += $"{Environment.NewLine}{itemNumber} - {item.Name} - Price: {itemAmount}";
            }

            displayText += $"{Environment.NewLine}{backMenu} - Back{Environment.NewLine}";

            Console.WriteLine(displayText);
            var answer = Console.ReadLine();

            while (!IsValidMenuSelection(answer, 1, backMenu))
            {
                Console.WriteLine("That is not a valid item choice. Please try again.");
                Console.WriteLine(displayText);
                answer = Console.ReadLine();
            }
            var selectedAnswer = int.Parse(answer);
            if (selectedAnswer == backMenu)
                return new PlanetMenu { ChosenItem = null, ExitingMenu = true };

            var pickedItem = itemDictionary[selectedAnswer];
            return new PlanetMenu { ChosenItem = pickedItem, ExitingMenu = false };
        }

        private bool IsValidMenuSelection(string enteredText, int minChoice, int maxChoice)
        {
            var numberList = new List<int>();

            for (var num = minChoice; num <= maxChoice; num++)
            {
                numberList.Add(num);
            }

            if (int.TryParse(enteredText, out var number))
            {
                if (numberList.Contains(number))
                    return true;

                Console.WriteLine("Error: Invalid Menu Selection");
            }
            else
            {
                Console.WriteLine("Error: Invalid Input");
            }

            return false;


        }

       
    }
}

