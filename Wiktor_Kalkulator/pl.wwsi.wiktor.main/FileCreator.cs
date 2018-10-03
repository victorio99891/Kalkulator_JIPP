using System;
using System.Diagnostics;
using System.IO;

namespace Wiktor_Kalkulator {
    public class FileCreator {
        public void saveToFile(string result) {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"results.txt", true)) {
                file.WriteLine(result);
                Console.WriteLine("\nYour result is succesfully saved!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                /*Process.Start(@"results.txt");*/
            }
        }

        public void readFile() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string[] lines = System.IO.File.ReadAllLines(@"results.txt");
            Console.WriteLine("All results from results.txt file:");
            for (int i = 0; i < lines.Length; i++) {
                int tmpid = i + 1;
                Console.WriteLine(tmpid + ". " + lines[i]);
            }

            Console.ResetColor();
        }

        public void clearFileContext() {
            File.WriteAllText(@"results.txt", String.Empty);
        }
    }
}