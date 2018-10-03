using System;
using System.Linq;

namespace Wiktor_Kalkulator {
    public class UserNumberAndSign {
        public int getNumberFromUser() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type integer number:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            string inputString = Console.ReadLine();
            Console.ResetColor();
            int inputNumber;
            if (!Int32.TryParse(inputString, out inputNumber)) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input is not a number or null!");
                Console.ResetColor();
                return getNumberFromUser();
            }

            return inputNumber;
        }

        public string getSignFromUser() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose one of possible operations:  (+,-,*,/,%,^)");
            Console.ResetColor();
            string[] possibleSignList = new RandomNumbersAndSign().Signs;
            Console.ForegroundColor = ConsoleColor.Green;
            string inputString = Console.ReadLine();
            Console.ResetColor();
            for (int i = 0; i < possibleSignList.Length; i++) {
                if (!possibleSignList.Contains(inputString)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong calculating sign or null!");
                    Console.ResetColor();
                    return getSignFromUser();
                }
            }

            return inputString;
        }
    }
}