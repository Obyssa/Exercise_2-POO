using System;

namespace Exercice3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Employe employe = new Employe(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
            employe.Age();

            employe.Anciennete();

            employe.AugmentationDuSalaire();
            employe.AfficherEmployé();
        }
    }
}
