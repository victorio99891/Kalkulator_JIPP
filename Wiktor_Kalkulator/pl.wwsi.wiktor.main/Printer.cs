using System;

namespace Wiktor_Kalkulator {
    public class Printer {
        public void printIntegerWholeList(int[] lista) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Printing list...\n{Length: [" + lista.Length + "]  Numbers: [");

            for (int i = 0; i < lista.Length; i++) {
                if (i != lista.Length - 1) {
                    Console.Write(lista[i] + ", ");
                }
                else {
                    Console.Write(lista[i]);
                }
            }

            Console.Write("]}\n");
            Console.ResetColor();
        }

        public void printStringWholeList(string[] lista) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPrinting random generated calculations:");
            for (int i = 0; i < lista.Length; i++) {
                int tmpid = i + 1;
                Console.WriteLine(tmpid + ". " + lista[i]);
            }
            Console.ResetColor();
        }

        public void printResult(string result) {
            Console.WriteLine("Your result is: " + result);
        }
    }
}