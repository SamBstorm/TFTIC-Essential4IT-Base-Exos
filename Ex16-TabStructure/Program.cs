using Ex16_TabStructure;

const int TAILLE = 5;

Point?[,] grille = new Point?[TAILLE, TAILLE];

//Console.WriteLine(grille[0,0]?.ToString() ?? "null");

for (int i = 0; i < TAILLE; i++)
{
    Point p;
    p.X = i + 1;
    p.Y = i + 1;
    grille[i, i] = p;
}

for (int i = 0; i < TAILLE; i++)
{
    for (int j = 0; j < TAILLE; j++)
    {
        if (grille[i,j] is null)
        {
            Console.Write("\t");
        }
        else
        {
            Console.Write($"X : {((Point)grille[i,j]).X} - Y : {grille[i,j]?.Y} ");
        }
    }
    Console.WriteLine();
}