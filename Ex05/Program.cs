// Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.  //Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97. //(utilisez la méthode « Substring » de la classe « string »). Console.WriteLine("Entrez un bban, svp"); string bban = Console.ReadLine(); string numero = bban.Substring(0, 10); string checkDigit = bban.Substring(10, 2);  long numeroLong = long.Parse(numero); int checkDigitInt = int.Parse(checkDigit); int modulo = (int)(numeroLong % 97);  if (modulo == checkDigitInt && checkDigitInt != 0 ||  modulo == 0 && checkDigitInt == 97)
{
    Console.WriteLine("OK");
} 
else
{
    Console.WriteLine("KO");
}   // ex2:000000009797 : OK  // ex2:000000009700 : KO // ex2:001334798105 : OK // ex2:001334798106 : KO