// Bonus : Calculer la racine carré d’un nombre avec maximum 10 décimales
// (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse),
Console.WriteLine("Racine de quel nombre ?");
int nombre = Convert.ToInt32(Console.ReadLine());
double min = 1;
double max = nombre;
double milieu=0;
int i = 0;
while ((max-min) > 1e-10)
{
    milieu = (min + max) / 2;
    if (milieu*milieu < nombre)
    {
        min = milieu;
    } 
    else if (milieu*milieu > nombre)
    {
        max = milieu;
    }
    else
    {
        break;
    }
    i++;
}
Console.WriteLine(milieu);
Console.WriteLine(Math.Sqrt(nombre));
Console.WriteLine($"{i} iterations");