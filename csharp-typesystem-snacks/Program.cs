// Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci due valori numerici e ti dirò quale dei due è maggiore.");
Console.Write("Inserisci il primo numero: ");
float firstChoosenNumber = float.Parse(Console.ReadLine());

Console.Write("Inserisci il secondo numero: ");
float secondChoosenNumber = float.Parse(Console.ReadLine());

if(firstChoosenNumber > secondChoosenNumber)
{
    Console.WriteLine($"Il numero maggiore è: {firstChoosenNumber}");
} else if(firstChoosenNumber < secondChoosenNumber)
{
    Console.WriteLine($"Il numero maggiore è: {secondChoosenNumber}");
} else
{
    Console.WriteLine("I due numeri inseriti sono uguali");
}

// Snack 2 : L’utente inserisce due parole in successione.
// Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci due parole e ti dirò quale delle due è la più lunga");
Console.Write("Inserisci la prima parola: ");
string firstChoosenWord = Console.ReadLine();

Console.Write("Inserisci la seconda parola: ");
string secondChoosenWord = Console.ReadLine();

if(firstChoosenWord.Length > secondChoosenWord.Length)
{
    Console.WriteLine($"La parola più lunga inserita è: {firstChoosenWord}");
} else if (firstChoosenWord.Length < secondChoosenWord.Length)
{
    Console.WriteLine($"La parola più lunga inserita è: {secondChoosenWord}");
} else
{
    Console.WriteLine("Le parole inserite hanno la stessa lunghezza");
}

// Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.
// Il programma stampa la somma di tutti i numeri inseriti.

Console.WriteLine("Inserisci 10 numeri uno dopo l'altro e ne eseguirò la somma");

float sumAccumulator = new float();

for(int i = 0; i < 10; i++)
{
    Console.Write($"Inserisci il {(i + 1)}° numero: ");
    sumAccumulator += float.Parse(Console.ReadLine());
}

Console.WriteLine($"{Environment.NewLine}La somma dei numeri inseriti è: {sumAccumulator}");