// Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN(BExx-xxxx-xxxx-xxxx).
// Trouvez la démarche via un moteur de recherche.

// bban : 001_3347981_05 = 0013_3479_8105
//dummy iban avec le code du pays suivi de 00 : BE00_0013_3479_8105
//4 1er caractères à la fin : 0013_3479_8105_BE00
//remplacer les lettres par leur valeur (A=10, B = 11, ..., E = 14,...) : 0013_3479_8105_111400
//calculer modulo : 001334798105111400 % 97 = 2
//calculer check digit : 98 - 2 = 96
//resultat: code pays +modulo + bban BE96 0013 3479 8105
Console.WriteLine("Entrez un bban, svp");
string bban = Console.ReadLine();
string bbanDummy = bban + "111400";
long numero = long.Parse(bbanDummy);
int modulo = (int)(numero % 97);
int checkDigit = 98 - modulo;
string checkDigitString = checkDigit < 10 ? "0" + checkDigit : checkDigit.ToString();
//if (checkDigit < 10)
//{
//    checkDigitString = "0" + checkDigit;
//}
//else 
//{
//    checkDigitString = checkDigit.ToString();
//}
string iban = "BE" + checkDigitString + bban;
Console.WriteLine($"iban : {iban}");