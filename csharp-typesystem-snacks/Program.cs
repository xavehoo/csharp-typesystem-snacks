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
