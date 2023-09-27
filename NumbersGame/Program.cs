namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);

            int triesLimit = 5;
            int tries = 0;
            int guess = 0;

            while (guess != number && tries < triesLimit)
            {
                tries++;
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!\n");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!\n");
                }
                else
                {
                    Console.WriteLine($"Wohoo! Rätt svar var: {number} Du klarade det på {tries} försök.");
                }
            }
            if (tries == triesLimit && guess != number)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }
            Console.ReadLine();
        }
    }
}