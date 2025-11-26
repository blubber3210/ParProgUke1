using System.Diagnostics.Tracing;

namespace ParProgUke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var deltagere = new Deltager[]
            //{
            //    new Deltager("Elida", 30, "Blondt",
            //        ["Jeg liker å klatre rundt", "Jeg er skikkelig dårlig til å synge"]),
            //    new Deltager("Christian", 36, "Havanna", ["I like to draw", "I listen to music"]),

            //};

            List<Deltager> deltagere = new List<Deltager>();

            Deltager Elida = new Deltager("Elida", 30, false, "Blondt",
                ["Jeg liker å klatre rundt", "Jeg er skikkelig dårlig til å synge"]);

            Deltager Christian = new Deltager("Christian", 36, true, "Havanna", ["I like to draw", "I listen to music"]);
            

            deltagere.Add(Elida);
            deltagere.Add(Christian);

            Console.WriteLine("Vi er: ");
            Console.WriteLine();

            foreach (var deltager in deltagere)
            {
                deltager.PrintText();
                Console.WriteLine();
            }

            Console.WriteLine("Hvem er du? ");
            Console.Write("Navn: ");
            string Navn = Console.ReadLine();
            Console.Write("Alder: ");
            int Alder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Er du mann eller kvinne?");
            Console.WriteLine("1. Mann\n 2. Kvinne");
            bool Gender = Convert.ToInt32(Console.ReadLine()) != 2;
            Console.Write("Hårfarge: ");
            string Haarfarge = Console.ReadLine();
            Console.Write("Hobby1: ");
            string Hobby1 = Console.ReadLine();
            Console.Write("Hobby2: ");
            string Hobby2 = Console.ReadLine();

            Deltager nyVenn = new Deltager(Navn, Alder, Gender, Haarfarge, [Hobby1, Hobby2]);

            deltagere.Add(nyVenn);

            Console.WriteLine();
            Thread.Sleep(400);
            Console.WriteLine("Heisann, du er: ");
            nyVenn.PrintText();

            
            Console.Read();
        }
    }
}
