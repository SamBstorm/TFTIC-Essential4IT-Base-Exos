using Ex19_Cartes;

Carte[] paquet = new Carte[52];

int i = 0;

#region Méthode des slides...
//foreach (string color in Enum.GetNames<Couleurs>())
//{
//    Couleurs current_color = Enum.Parse<Couleurs>(color);
//    foreach (string value in Enum.GetNames<Valeurs>())
//    {
//        Valeurs current_value = Enum.Parse<Valeurs>(value);
//        paquet[i].couleur = current_color;
//        paquet[i].valeur = current_value;
//        i++;
//    }
//} 
#endregion

#region Avec GetValues()

foreach (Couleurs color in Enum.GetValues<Couleurs>())
{
    foreach (Valeurs value in Enum.GetValues<Valeurs>())
    {
        paquet[i].couleur = color;
        paquet[i].valeur = value;
        i++;
    }
}

#endregion

foreach (Carte carte in paquet)
{
    Console.WriteLine($"{carte.valeur} de {carte.couleur}");
}

Random RNG = new Random();

for(int pass = 0; pass < 100; pass++)
{
    int indice_first = RNG.Next(paquet.Length);
    int indice_last = RNG.Next(paquet.Length);

    Carte temp = paquet[indice_first];
    paquet[indice_first] = paquet[indice_last];
    paquet[indice_last] = temp;
}

foreach (Carte carte in paquet)
{
    Console.WriteLine($"{carte.valeur} de {carte.couleur}");
}
