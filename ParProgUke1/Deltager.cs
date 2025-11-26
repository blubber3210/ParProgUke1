using System;
using System.Collections.Generic;
using System.Text;

namespace ParProgUke1
{
    internal class Deltager
    {
        public Deltager(string name, int age, string hairColor, string[] hobbies)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
            Hobbies = hobbies;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string[] Hobbies { get; set; }

        public void PrintText()
        {
            Console.WriteLine("Hei, mitt navn er " + Name);
            Console.WriteLine($"Jeg er {Age} år gammel");
            Console.WriteLine("Mitt hår er " + HairColor);
            for (int i = 0; i < Hobbies.Length; i++)
            {
                Console.WriteLine(Hobbies[i]);
            }
        }
    }
}
