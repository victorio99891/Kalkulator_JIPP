using System;

namespace Wiktor_Kalkulator {
    public class Calculator {
        private double _numberOne;
        private double _numberTwo;
        private string _operationSign;


        public string calculate(int a, int b, string s) {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            double tmp;

            switch (s) {
                case "+":
                    tmp = a + b;
                    break;
                case "-":
                    tmp = a - b;
                    break;
                case "*":
                    tmp = (double) a * b;
                    break;
                case "/":
                    if (b == 0) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        return "Dividing by zero is forbidden!";
                    }

                    tmp = (double) a / b;
                    break;
                case "%":
                    tmp = a % b;
                    break;
                case "^":
                    tmp = Math.Pow(a, b);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "Something went wrong.. Try Again!\nInfo: Probably your sign '" + s +
                           "' don't match to calculate operation.";
            }


            return resultStringFactory(a, b, tmp, s);
        }

        public string calculateFromUserInput(UserNumberAndSign userController, Printer printer) {
            int numberOne = userController.getNumberFromUser();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->> CORRECT <<--");
            Console.ResetColor();
            string sign = userController.getSignFromUser();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->> CORRECT <<--");
            Console.ResetColor();
            int numberTwo = userController.getNumberFromUser();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->> CORRECT <<--");
            Console.ResetColor();
            string result = calculate(numberOne, numberTwo, sign);
            Console.WriteLine();
            printer.printResult(result);
            Console.WriteLine();
            return result;
        }

        private string resultStringFactory(int a, int b, double result, string s) {
            return a + " " + s + " " + b + " = " + result;
        }


        public double NumberOne {
            get => _numberOne;
            set => _numberOne = value;
        }

        public double NumberTwo {
            get => _numberTwo;
            set => _numberTwo = value;
        }

        public string OperationSign {
            get => _operationSign;
            set => _operationSign = value;
        }
    }
}