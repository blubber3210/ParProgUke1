using System;
using System.Collections.Generic;
using System.Text;

namespace ParProgUke1
{
    internal class Deltager
    {
        public Deltager(string name, int age, bool gender, string hairColor, string[] hobbies)
        {
            Name = name;
            Age = age;
            Gender = gender;
            HairColor = hairColor;
            Hobbies = hobbies;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender  { get; set; }
        public string HairColor { get; set; }
        public string[] Hobbies { get; set; }

        public void PrintText()
        {
            if (Gender == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if(Gender == false)
            {
               Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            }
            Console.WriteLine("Hei, mitt navn er " + Name);
            Console.WriteLine($"Jeg er {Age} år gammel");
            Console.WriteLine("Mitt hår er " + HairColor);
            for (int i = 0; i < Hobbies.Length; i++)
            {
                Console.WriteLine(Hobbies[i]);
            }
            Console.ResetColor();
        }
    }
}
