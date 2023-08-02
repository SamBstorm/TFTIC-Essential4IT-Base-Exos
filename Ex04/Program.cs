// Calcule de la division entière, du modulo et de la division de deux entiers.
// Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo: 1, Division: 2,5.
int a, b;
Console.WriteLine("Entrez un 1er nombre entier, svp");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez un 2e nombre entier, svp");
b = Convert.ToInt32(Console.ReadLine());
int divisionEntiere = a / b;
int modulo = a % b;
double division = (double)a / b;
Console.WriteLine($"Division entiere : {divisionEntiere}");
Console.WriteLine($"Modulo : {modulo}");
Console.WriteLine($"Division : {division}");