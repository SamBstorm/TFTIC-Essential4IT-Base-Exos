// See https://aka.ms/new-console-template for more information
Console.WriteLine("Factorielle de quel nombre ?");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= i;
}
Console.WriteLine(result);