// See https://aka.ms/new-console-template for more information
Console.WriteLine("Combien de nombres premiers ?");
int x = Convert.ToInt32(Console.ReadLine());
int countNbPremiers = 0;
int nombreATester = 2;
while (countNbPremiers < x)
{
    int nbDiviseurs = 0;
    for (int diviseur = 1; diviseur <= nombreATester; diviseur++)
    {
        if (nombreATester%diviseur == 0) // nombre a tester divisible par diviseur
        {
            nbDiviseurs++;
        }
    }
    if (nbDiviseurs == 2)
    {
        Console.WriteLine(nombreATester);
        countNbPremiers++;
    }
    nombreATester++;
}