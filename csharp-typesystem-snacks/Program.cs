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

// Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

int resultAccumulator = new int();

for(int i = 1;i < 10; i++)
{
    resultAccumulator += (i + 1);
}

Console.WriteLine($"La somma dei numeri da 2 a 10 è pari a {resultAccumulator} ed il valore medio è {resultAccumulator / 9}");

//Snack 5: Il software chiede all’utente di inserire un numero.
//Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.Write("Inserisci un numero intero e riconoscerò se è pari:");
int userChoosenNumber = int.Parse(Console.ReadLine());

if(userChoosenNumber % 2 == 0)
{
    Console.WriteLine($"Il numero che hai inserito è pari: {userChoosenNumber}");
} else
{
    Console.WriteLine($"Il numero che hai inserito è dispari, il numero successivo al numero inserito è: {userChoosenNumber + 1}");
}

// Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
// Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] guestList = { "alex", "luca", "paola", "chiara", "simone" };

Console.Write("Dimmi il tuo nome e ti dirò se sei invitato alla festa: ");
string nameToCheck = Console.ReadLine();

if(guestList.Contains(nameToCheck.ToLower()))
{
    Console.WriteLine("Prego, entri pure, lei è nella lista!");
} else
{
    Console.WriteLine("Mi dispiace ma il suo nome non è presente nella lista.");

}

// Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero,
// se è dispari inseriscilo nell’array.

int[] oddsNumberContainer = new int[6];

Console.WriteLine("Ti chiedo di inserire 6 numeri interi e salverò in memoria i numeri dispari che inserirai.");

for(int i = 0; i < 6; i++)
{
    Console.Write($"Inserisci il {i + 1}° numero: ");
    int userNumber = int.Parse(Console.ReadLine());
    if (userNumber % 2 != 0)
    {
        oddsNumberContainer[i] = userNumber;
        Console.WriteLine("Numero dispari salvato!");
    }
}

// Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numbersList = { 1, 6, 3, 6, 7, 9, 34, 54, 12, 89, 3, 12, 90, 11, 51, 63, 9 };
int result = new int();

for(int i = 0; i < numbersList.Length; i++)
{
    if(i % 2 != 0)
    {
        result += numbersList[i];
    }
}

Console.WriteLine($"La somma dei numeri contenuti nelle locazioni dispari dell'array è: {result}");