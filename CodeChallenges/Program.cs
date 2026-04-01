// Oppgave 1 - Variabler

string navn = "Venn Vennlig";
int alder = 33;
double høyde = 1.80;
char forbokstav = 'V';
bool erStudent = true;

Console.WriteLine(navn);
Console.WriteLine(alder);
Console.WriteLine(høyde);
Console.WriteLine(forbokstav);
Console.WriteLine(erStudent);

// Oppgave 2 - Kalkulator
Calculator calc = new Calculator();

Console.WriteLine(calc.Add(10, 5));
Console.WriteLine(calc.Subtract(10, 5));
Console.WriteLine(calc.Multiply(10, 5));
Console.WriteLine(calc.Divide(10, 5));

// Oppgave 2 - Brukerinput
Console.WriteLine("Velg operasjon: 1=Add, 2=Subtract, 3=Multiply, 4=Divide");
string valg = Console.ReadLine();

Console.WriteLine("Skriv inn første tall:");
double tall1 = double.Parse(Console.ReadLine());

Console.WriteLine("Skriv inn andre tall:");
double tall2 = double.Parse(Console.ReadLine());

switch (valg)
{
    case "1":
        Console.WriteLine($"Svar: {calc.Add(tall1, tall2)}");
        break;
    case "2":
        Console.WriteLine($"Svar: {calc.Subtract(tall1, tall2)}");
        break;
    case "3":
        Console.WriteLine($"Svar: {calc.Multiply(tall1, tall2)}");
        break;
    case "4":
        Console.WriteLine($"Svar: {calc.Divide(tall1, tall2)}");
        break;
    default:
        Console.WriteLine("Ugyldig valg!");
        break;
}


//Oppgave 3 
// - Array

string[] navnet = { "Hugin", "Munin", "Fenrir" };
int[] tall = { 1, 2, 3, 4, 5};
double[] priser = {9.99, 19.99, 29.99};

foreach (string n in navnet)
{
    Console.WriteLine(n);
}

foreach (int t in tall)
{
    Console.WriteLine(t);
}

foreach (double p in priser)
{
    Console.WriteLine(p);
}

// - List

List<string> handleListe = ["Kylling", "Bacon", "Ost"];
List<int> tall3 = [1, 2, 3, 4, 5];
List<double> priser2 = [9.99, 19.99, 29.99];

foreach (string vare in handleListe)
{
    Console.WriteLine(vare);
}

foreach (int t in tall3)
{
    Console.WriteLine(t);
}

foreach (double p in priser2)
{
    Console.WriteLine(p);
}


// - Dictionary

Dictionary<string, string> hovedsteder = new Dictionary<string, string>();
hovedsteder.Add("Norge", "Oslo");
hovedsteder.Add("Island", "Reykjavik");
hovedsteder.Add("Danmark", "København");

Dictionary<string, int> alder3 = new Dictionary<string, int>();
alder3.Add("Bob", 42);
alder3.Add("Alice", 101010);
alder3.Add("Julius", 56);

foreach (KeyValuePair<string, string > land in hovedsteder)
{
    Console.WriteLine($"{land.Key} - {land.Value}");
}

foreach (KeyValuePair<string, int> person in alder3)
{
    Console.WriteLine($"{person.Key} - {person.Value}");
}