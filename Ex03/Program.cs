//// See https://aka.ms/new-console-template for more information
//// Demander a l'utilisateur d'encoder un nombre

//// declarer 2 entiers : a et b
//int chaineConvertieEnEntier, resultat;
//// afficher le message "Entrez un entier, svp" 
//Console.WriteLine("Entrez un entier, svp");
//// lire un entier et le stocker dans a
//string chaineIntroduite = Console.ReadLine();
//chaineConvertieEnEntier = Convert.ToInt32(chaineIntroduite);

//// faire la somme des 2 moitiers (de n1)
//resultat = chaineConvertieEnEntier / 2 + chaineConvertieEnEntier / 2; // -> resultat 

//// si resultat = chaineConvertieEnEntier alors "Le nombre est pair" sinon "Le nombre est impair"
//if (resultat == chaineConvertieEnEntier) {
//    // afficher « le nombre est paire » 
//    Console.WriteLine("le nombre est paire");
//}
//else
//{
//    Console.WriteLine("Le nombre est impair");
//}


object o = 5;
int? i = o as int?;
Console.WriteLine(i);
bool? b = o as bool?;
if (b is null)
{
    Console.WriteLine("b n'est pas un boolean");
}