using System;

namespace classe_exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre livre = new Livre("mais nan", "bah oe", 12);

            Livre livre1 = new Livre("c'est ça", "moi", 12);

            Console.WriteLine(livre.Afficher());
            Console.WriteLine(livre1.Afficher());

        }
    }
}
