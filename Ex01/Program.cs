// See https://aka.ms/new-console-template for more information
// Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition,
// la conversion devra utiliser la méthode « int.Parse() »


// declarer 2 entiers a et b
int a, b;
string n1, n2;
// demander un entier a l'utilisateur
    // afficher dans la console "Entrez un 1er nombre entier" 
Console.WriteLine("Entrez un 1er nombre entier");
    // lire la console
n1 = Console.ReadLine();
    // convertir ce qui a ete lu en entier et le stocker dans a
a = int.Parse(n1);

// demander un entier a l'utilisateur
// afficher dans la console "Entrez un 2e nombre entier" 
Console.WriteLine("Entrez un 2e nombre entier");
// lire la console
n2 = Console.ReadLine();
// convertir ce qui a ete lu en entier et le stocker dans b
b = int.Parse(n2);

// additionner a et b
int resultat = a + b;
// afficher le resultat dans la console.
Console.WriteLine(a + " + " + b + " = " + (a + b));
Console.WriteLine(a + " + " + b + " = " + resultat);
Console.WriteLine($"{a} + {b} = {resultat}");
Console.WriteLine($"{a} + {b} = {a+b}");
