// A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».  for (int facteur = 1; facteur <= 20; facteur++)
{
    for (int table = 1; table <= 5; table++)
    {
        Console.Write($"{table}x{facteur}={table * facteur}\t\t");
    }     Console.WriteLine(); } 