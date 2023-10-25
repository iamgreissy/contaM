using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il percorso della directory da controllare:");
        string directoryPath = Console.ReadLine();

        if (Directory.Exists(directoryPath))
        {
            string[] files = Directory.GetFiles(directoryPath); // Trova tutti i file nella directory.

            Console.WriteLine($"I seguenti file si trovano nella directory {directoryPath}:");

            bool trovati = false; // Una variabile per tenere traccia se sono stati trovati file che iniziano con "M".

            foreach (var fileName in files)
            {
                string nomeFile = Path.GetFileName(fileName); // Ottieni solo il nome del file.

                if (nomeFile.StartsWith("M", StringComparison.OrdinalIgnoreCase)) // Verifica se il nome del file inizia con "M" (ignorando maiuscole/minuscole).
                {
                    Console.WriteLine(nomeFile);
                    trovati = true; // Abbiamo trovato almeno un file che inizia con "M".
                }
            }

            if (!trovati)
            {
                Console.WriteLine("Non ci sono file che iniziano con 'M' in questa directory.");
            }
        }
        else
        {
            Console.WriteLine("La directory specificata non esiste.");
        }
    }
}
