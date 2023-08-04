using Ex18_Equation;

Equation2degre eq = new Equation2degre();

do
{
    Console.Clear();
    Console.WriteLine("Veuillez introduire la valeur de A selon l'équation Ax² + Bx + C :");
} while (!double.TryParse(Console.ReadLine(), out eq.A));


do
{
    Console.Clear();
    Console.WriteLine($"Veuillez introduire la valeur de B selon l'équation {eq.A}x² + Bx + C :");
} while (!double.TryParse(Console.ReadLine(), out eq.B));


do
{
    Console.Clear();
    Console.WriteLine($"Veuillez introduire la valeur de C selon l'équation {eq.A}x² + {eq.B}x + C :");
} while (!double.TryParse(Console.ReadLine(), out eq.C));

Console.Clear();
Console.WriteLine($"La formule est {eq.A}x² + {eq.B}x + {eq.C}");

double? x1, x2;

if(eq.ResoudreV3(out x1, out x2))
{
    Console.Write("L'équation est résolvable ");
    if (x1 == x2) Console.WriteLine($"x vaut {x1}.");
    else Console.WriteLine($"x peut valoir soit {x1}, soit {x2}.");
}
else Console.WriteLine("L'équation n'est pas résolvable...");
