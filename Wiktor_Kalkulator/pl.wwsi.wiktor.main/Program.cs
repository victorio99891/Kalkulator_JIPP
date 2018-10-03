using System;

namespace Wiktor_Kalkulator {
    internal class Program {
        private static Calculator calculator = new Calculator();
        private static RandomNumbersAndSign randomizer = new RandomNumbersAndSign();
        private static UserNumberAndSign userController = new UserNumberAndSign();
        private static Printer printer = new Printer();
        private static FileCreator fileCreator = new FileCreator();
        private static Menu menu = new Menu();

        public static void Main(string[] args) {
            Console.BackgroundColor = ConsoleColor.Black;
            start();
        }

        public static void start() {
            int userInput = menu.getMenuInput();
            switch (userInput) {
                case 1:
                    string result = calculator.calculateFromUserInput(userController, printer);
                    menu.proposeSaveResultOption(result, fileCreator);
                    start();
                    break;
                case 2:
                    randomizer.createRandomListInRange(1, 20);
                    printer.printIntegerWholeList(randomizer.Numbers);
                    string[] randomCalculations = new string[10];
                    for (int i = 0; i < randomCalculations.Length; i++) {
                        randomCalculations[i] = calculator.calculate(randomizer.getRandomNumberFromList(),
                            randomizer.getRandomNumberFromList(), randomizer.getRandomMathSignFromList());
                    }

                    printer.printStringWholeList(randomCalculations);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    start();
                    break;
                case 3:
                    fileCreator.readFile();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    start();
                    break;
                case 4:
                    fileCreator.clearFileContext();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Your file is successfully cleared!");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    start();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    start();
                    break;
            }
        }
    }
}