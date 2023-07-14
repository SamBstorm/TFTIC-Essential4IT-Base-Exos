namespace Exo02_ConvertisseurSecondes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temps, jours, heures, minutes, secondes;
            Console.WriteLine("Veuillez renseigner le nombre de secondes totales :");
            temps = int.Parse(Console.ReadLine());

            secondes = temps % 60;
            minutes = (temps / 60) % 60;
            heures = (temps / 3600) % 24;
            jours = temps / 86400;

            //Console.WriteLine("{0} secondes donne {1} jour(s) {2} heure(s) {3} minute(s) {4} secondes",temps,jours,heures,minutes,secondes);

            Console.WriteLine(
                $"{temps} secondes donne {jours} jour(s)" +
                $" {heures} heure(s) {minutes} minute(s)" +
                $" {secondes} secondes");
        }
    }
}