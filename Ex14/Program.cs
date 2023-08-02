// Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).

Console.WriteLine("Combien de nombres premiers ?");
int x = Convert.ToInt32(Console.ReadLine());

List<int> nombrePremiers = new List<int>();

for (int nombreATester = 2; nombrePremiers.Count < x; nombreATester++)
{
    bool isPrime = true;
    for (int i=0; isPrime && i < nombrePremiers.Count && nombrePremiers[i]* nombrePremiers[i] <= nombreATester; i++)
    {
        if (nombreATester % nombrePremiers[i] == 0)
        {
            isPrime = false; break;
        }
    }
    if (isPrime)
    {
        nombrePremiers.Add(nombreATester);
    }
}


foreach (object o in nombrePremiers)
{
    Console.WriteLine((int)o);
}