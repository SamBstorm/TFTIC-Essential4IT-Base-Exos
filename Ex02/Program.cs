// declarer 2 entiers a et b
int a, b;
string n1, n2;
bool aOk, bOk;
// demander un entier a l'utilisateur
// afficher dans la console "Entrez un 1er nombre entier" 
Console.WriteLine("Entrez un 1er nombre entier");
// lire la console
n1 = Console.ReadLine();
// convertir ce qui a ete lu en entier et le stocker dans a
aOk = int.TryParse(n1, out a);

// demander un entier a l'utilisateur
// afficher dans la console "Entrez un 2e nombre entier" 
Console.WriteLine("Entrez un 2e nombre entier");
// lire la console
n2 = Console.ReadLine();
// convertir ce qui a ete lu en entier et le stocker dans b
bOk = int.TryParse(n2, out b);

// additionner a et b
int resultat = a + b;
// afficher le resultat dans la console.
//if (aOk)
//{
    Console.WriteLine(a + " + " + b + " = " + (a + b));
    Console.WriteLine(a + " + " + b + " = " + resultat);
    Console.WriteLine($"{a} + {b} = {resultat}");
    Console.WriteLine($"{a} + {b} = {a + b}");
//}