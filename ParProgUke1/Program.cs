using System.Diagnostics.Tracing;

namespace ParProgUke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deltagere = new Deltager[]
            {
                new Deltager("Elida", 30, "Blondt",
                    ["Jeg liker å klatre rundt", "Jeg er skikkelig dårlig til å synge"]),
                new Deltager("Christian", 36, "Havanna", ["I like to draw", "I listen to music"]),

            };

            //deltagere[0].PrintText();

            foreach (var deltager in deltagere)
            {
                deltager.PrintText();
                Console.WriteLine();
            }

            
        }
    }
}
