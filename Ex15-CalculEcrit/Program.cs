Console.WriteLine("Veuillez introduire un premier nombre : ");
string nb1 = Console.ReadLine();
while (!int.TryParse(nb1, out _))
{
    Console.WriteLine("Veuillez introduire un premier nombre qui est entier : ");
    nb1 = Console.ReadLine();
}

Console.WriteLine("Veuillez introduire un second nombre : ");
string nb2 = Console.ReadLine();
while (!int.TryParse(nb2, out _))
{
    Console.WriteLine("Veuillez introduire un second nombre qui est entier : ");
    nb2 = Console.ReadLine();
}

#region Boucle avec fonctions
//while (nb1.Length != nb2.Length)
//{
//    if (nb1.Length < nb2.Length) nb1.PadLeft(nb2.Length, '0');
//    else nb2.PadLeft(nb1.Length, '0');
//} 
#endregion

#region Boucle sans fonction
while (nb1.Length < nb2.Length)
{
    nb1 = "0" + nb1;
}

while (nb2.Length < nb1.Length)
{
    nb2 = "0" + nb2;
}
#endregion

char[] nb1_char = nb1.ToCharArray();
char[] nb2_char = nb2.ToCharArray();

string result = "";
int report = 0;

for (int i = nb1.Length - 1; i >= 0; i--)
{
    int nb1_value = nb1_char[i]-48;
    int nb2_value = nb2_char[i]-48;
    int result_value = report + nb1_value + nb2_value;
    if(result_value >= 10)
    {
        report = 1;
        result_value = result_value - 10;
    }
    else
    {
        report = 0;
    }
    result = result_value + result;
}
if (report > 0) result = report + result;
Console.WriteLine(result);