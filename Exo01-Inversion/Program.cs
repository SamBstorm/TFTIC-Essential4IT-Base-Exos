namespace Exo01_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables : je prépare la mémoire
            int a, b, temp;

            //Initialisation des variables : mes variables ont des valeurs
            a = 5;
            b = 7;

            //Affichage de controle
            Console.WriteLine("La valeur de a est {0}, et la valeur de b est {1}", a, b);

            //Inversion
            temp = a;
            a = b;
            b = temp;

            //Affichage de controle
            Console.WriteLine("La valeur de a est {0}", a);
            Console.WriteLine("La valeur de b est {0}", b);
        }
    }
}