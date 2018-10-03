using System;

namespace Wiktor_Kalkulator {
    public class Menu {
        public void printMenu() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome in WiCalc 2018! What you want to do?");
            Console.WriteLine("1 - Make calculations");
            Console.WriteLine("2 - Generate random calculations");
            Console.WriteLine("3 - Load results file (history of all calculations)");
            Console.WriteLine("9 - Exit application");
        }

        private static void printSaveMenu() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Do you want to save this result into file?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
        }

        public int getMenuInput() {
            Console.Clear();
            printMenu();
            string userInput = Console.ReadLine();
            int userInputNumber;
            if (!Int32.TryParse(userInput, out userInputNumber)) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input should be a number!");
                Console.ResetColor();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return getMenuInput();
            }

            return userInputNumber;
        }

        public int getSaveMenuInput() {
            printSaveMenu();
            string userInput = Console.ReadLine();
            int userInputNumber;
            if (!Int32.TryParse(userInput, out userInputNumber)) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input should be a number!");
                Console.ResetColor();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return getSaveMenuInput();
            }

            return userInputNumber;
        }


        public void proposeSaveResultOption(string result, FileCreator creator) {
            int userInput = getSaveMenuInput();
            switch (userInput) {
                case 1:
                    creator.saveToFile(result);
                    break;
                case 2:
                    Program.start();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input...");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    proposeSaveResultOption(result, creator);
                    break;
            }
        }
    }
}