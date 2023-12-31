﻿Console.WriteLine("Snack 1: Trova il numero maggiore");
Console.WriteLine("Snack 2 : Trova la parola più lunga");
Console.WriteLine("Snack 3: Somma di 10 numeri");
Console.WriteLine("Snack 4: Somma e media dei numeri a 2 a 10");
Console.WriteLine("Snack 5: Riconosci se un numero è pari o dispari");
Console.WriteLine("Snack 6: Lista degli invitati");
Console.WriteLine("Snack 7: Memorizza i numeri dispari");
Console.WriteLine("Snack 8: Somma di numeri nelle locazioni dispari dell'array");
Console.WriteLine("Snack 9: Somma finchè i numeri inseriti sommati sono pari o superiori a 50");
Console.WriteLine("Snack 10: Generatore di array con numeri casuali da 1 a 100");
Console.Write("Inserisci un numero da 1 a 10 per decidere quale snack eseguire: ");
int userChoose = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

switch (userChoose)
{
    case 1:
        // Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

        Console.WriteLine("Inserisci due valori numerici e ti dirò quale dei due è maggiore.");
        Console.Write("Inserisci il primo numero: ");
        float firstChoosenNumber = float.Parse(Console.ReadLine() ?? "0");

        Console.Write("Inserisci il secondo numero: ");
        float secondChoosenNumber = float.Parse(Console.ReadLine() ?? "0");

        if (firstChoosenNumber > secondChoosenNumber)
        {
            Console.WriteLine($"Il numero maggiore è: {firstChoosenNumber}");
        }
        else if (firstChoosenNumber < secondChoosenNumber)
        {
            Console.WriteLine($"Il numero maggiore è: {secondChoosenNumber}");
        }
        else
        {
            Console.WriteLine("I due numeri inseriti sono uguali");
        }
        break;
    case 2:
        // Snack 2 : L’utente inserisce due parole in successione.
        // Il software stampa prima la parola più corta, poi la parola più lunga.

        Console.WriteLine("Inserisci due parole e ti dirò quale delle due è la più lunga");
        Console.Write("Inserisci la prima parola: ");
        string firstChoosenWord = Console.ReadLine() ?? string.Empty;

        Console.Write("Inserisci la seconda parola: ");
        string secondChoosenWord = Console.ReadLine() ?? string.Empty;

        if (firstChoosenWord.Length > secondChoosenWord.Length)
        {
            Console.WriteLine($"La parola più lunga inserita è: {firstChoosenWord}");
        }
        else if (firstChoosenWord.Length < secondChoosenWord.Length)
        {
            Console.WriteLine($"La parola più lunga inserita è: {secondChoosenWord}");
        }
        else
        {
            Console.WriteLine("Le parole inserite hanno la stessa lunghezza");
        }
        break;
    case 3:
        // Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.
        // Il programma stampa la somma di tutti i numeri inseriti.

        Console.WriteLine("Inserisci 10 numeri uno dopo l'altro e ne eseguirò la somma");

        float sumAccumulator = new();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Inserisci il {(i + 1)}° numero: ");
            sumAccumulator += float.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine($"{Environment.NewLine}La somma dei numeri inseriti è: {sumAccumulator}");
        break;
    case 4:
        // Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

        int resultAccumulator = new();

        for (int i = 1; i < 10; i++)
        {
            resultAccumulator += (i + 1);
        }

        Console.WriteLine($"La somma dei numeri da 2 a 10 è pari a {resultAccumulator} ed il valore medio è {resultAccumulator / 9}");
        break;
    case 5:
        //Snack 5: Il software chiede all’utente di inserire un numero.
        //Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

        Console.Write("Inserisci un numero intero e riconoscerò se è pari:");
        int userChoosenNumber = int.Parse(Console.ReadLine() ?? "0");

        if (userChoosenNumber % 2 == 0)
        {
            Console.WriteLine($"Il numero che hai inserito è pari: {userChoosenNumber}");
        }
        else
        {
            Console.WriteLine($"Il numero che hai inserito è dispari, il numero successivo al numero inserito è: {userChoosenNumber + 1}");
        }
        break;
    case 6:
        // Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
        // Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

        string[] guestList = { "alex", "luca", "paola", "chiara", "simone" };

        Console.Write("Dimmi il tuo nome e ti dirò se sei invitato alla festa: ");
        string nameToCheck = Console.ReadLine() ?? string.Empty;

        if (guestList.Contains(nameToCheck.ToLower()))
        {
            Console.WriteLine("Prego, entri pure, lei è nella lista!");
        }
        else
        {
            Console.WriteLine("Mi dispiace ma il suo nome non è presente nella lista.");

        }
        break;
    case 7:
        // Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero,
        // se è dispari inseriscilo nell’array.

        int[] oddsNumberContainer = new int[6];

        Console.WriteLine("Ti chiedo di inserire 6 numeri interi e salverò in memoria i numeri dispari che inserirai.");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Inserisci il {i + 1}° numero: ");
            int userNumber = int.Parse(Console.ReadLine() ?? "0");
            if (userNumber % 2 != 0)
            {
                oddsNumberContainer[i] = userNumber;
                Console.WriteLine("Numero dispari salvato!");
            }
        }
        break;
    case 8:
        // Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

        int[] numbersList = { 1, 6, 3, 6, 7, 9, 34, 54, 12, 89, 3, 12, 90, 11, 51, 63, 9 };
        int result = new();

        for (int i = 0; i < numbersList.Length; i++)
        {
            if (i % 2 != 0)
            {
                result += numbersList[i];
            }
        }

        Console.WriteLine($"La somma dei numeri contenuti nelle locazioni dispari dell'array è: {result}");
        break;
    case 9:
        // Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
        // Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando
        // la somma degli elementi è minore di 50.

        int[] userNumbers = new int[50];

        Console.WriteLine("Ti chiederò di inserire un numero alla volta fino al momento in cui la somma dei numeri inseriti raggiungerà 50, il valore minimo che puoi inserire è 1.");

        int sumCheck = 0;
        int index = 0;

        while (sumCheck < 50)
        {
            Console.WriteLine($"Inserisci il {index + 1}° numero: ");
            userNumbers[index] = int.Parse(Console.ReadLine() ?? "0");
            sumCheck += userNumbers[index];
            index++;
        }

        Console.WriteLine($"Fine! La somma dei numeri inseriti ha raggiunto il valore di: {sumCheck}, la quantità di numeri inseriti è pari a: {index}");
        break;
    case 10:
        // Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array,
        // ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

        Console.Write("Dimmi quanti array di numeri casiali da 1 a 100 vuoi generare: ");

        int arrayQuantity = int.Parse(Console.ReadLine() ?? "0");

        Random random = new();

        for (int i = 0; i < arrayQuantity; i++)
        {
            int[] randomNumbers = new int[10];
            Console.Write($"Il {i + 1}° array creato è composto dai seguenti valori: ");
            for (int j = 0; j < 10; j++)
            {
                randomNumbers[j] = random.Next(1, 100);
                Console.Write($"{randomNumbers[j]} ");
            }
            Console.WriteLine();
        }
        break;
    default:
        Console.WriteLine("Il numero che hai inserito non è compreso tra 1 e 10.");
        break;
}








