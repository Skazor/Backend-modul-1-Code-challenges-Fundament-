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