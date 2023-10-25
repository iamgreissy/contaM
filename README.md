# contaM
Questo esercizio serve a monitorare, attraverso il percorso dato al programma, e individuare i vari file che iniziano con la lettera "m" o "M" (senza dare conto alla maiuscola e alla minuscola)
Il programma inizia chiedendo all'utente di inserire il percorso di una directory tramite Console.ReadLine().
L'utente dovrebbe fornire un percorso completo di una directory, così da verificare della sua esistenza:

Il programma verifica se la directory specificata dall'utente esiste utilizzando Directory.Exists(directoryPath).
Se la directory esiste, il programma passa alla fase successiva.
Ricerca dei File nella Directory:

Utilizzando Directory.GetFiles(directoryPath), il programma trova tutti i file presenti nella directory specificata e li memorizza in un array di stringhe chiamato files.
Iterazione sui File:

Il programma avvia un ciclo foreach per scorrere ciascun file nella lista files.
Per ciascun file, ottiene solo il nome del file (senza il percorso completo) utilizzando Path.GetFileName(fileName).
Verifica se il nome del file inizia con "M", utilizzando nomeFile.StartsWith("M", StringComparison.OrdinalIgnoreCase).

In sintesi, questo programma permette all'utente di inserire il percorso di una directory, ricerca i file all'interno di quella directory, e mostra i nomi dei file che iniziano con "M". Se non trova tali file, mostra un messaggio appropriato. Se la directory specificata non esiste, verrà emesso un messaggio di errore.

```C#
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
```
