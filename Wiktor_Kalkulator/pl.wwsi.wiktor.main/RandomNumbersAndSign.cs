using System;

namespace Wiktor_Kalkulator {
    public class RandomNumbersAndSign {
        private Random random = new Random();

        private int[] numbers;
        private string[] signs = {"+", "-", "*", "/", "%", "^"};


        public RandomNumbersAndSign() {
        }

        public void createRandomListInRange(int start, int stop) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Creating list of numbers and size in range of: from " + start + " to " + stop);
            Console.ResetColor();
            int randomSize = random.Next(stop) + 10;
            int[] tmp = new int[randomSize];
            for (var i = 0; i < randomSize; i++) {
                tmp[i] = random.Next(stop) + start;
            }
            numbers = tmp;
        }


        public int getRandomNumberFromList() {
            Console.ResetColor();
            int tmp = random.Next(numbers.Length);
            return numbers[tmp];
        }

        public string getRandomMathSignFromList() {
            int tmp = random.Next(signs.Length);
            return signs[tmp];
        }

        public int[] Numbers {
            get => numbers;
            set => numbers = value;
        }

        public string[] Signs {
            get => signs;
            set => signs = value;
        }
    }
}