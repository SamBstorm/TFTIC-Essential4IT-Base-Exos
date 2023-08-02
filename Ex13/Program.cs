//Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.
using System.Collections;

Console.WriteLine("Nombre premiers jusqu'a ?");
int x = Convert.ToInt32(Console.ReadLine());
int nombreATester = 2;
ArrayList nombrePremiers = new ArrayList();
while (nombreATester < x)
{
    int nbDiviseurs = 0;
    for (int diviseur = 1; diviseur <= nombreATester; diviseur++)
    {
        if (nombreATester % diviseur == 0) // nombre a tester divisible par diviseur
        {
            nbDiviseurs++;
        }
    }
    if (nbDiviseurs == 2)
    {
        nombrePremiers.Add(nombreATester);
    }
    nombreATester++;
}
foreach(object o in nombrePremiers)
{
    Console.WriteLine((int)o);
}