using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3_POO
{
    class Employe
    {

        private int matricule;
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string dateEmbauche;
        private double salaire;
        


        public Employe(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, double salaire)
        {

            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;

        }

        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }
        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }
            set
            {
                dateNaissance = value;
            }
        }
        public string DateEmbauche
        {
            get
            {
                return dateEmbauche;
            }
            set
            {
                dateEmbauche = value;
            }
        }
        public double Salaire
        {
            get
            {
                return salaire;
            }
            set
            {
                salaire = value;
            }
        }
        
        public void Age()
        {
            DateTime naissance = Convert.ToDateTime(dateNaissance);
            int age = DateTime.Now.Year - naissance.Year;
            DateTime dateAnniv = new DateTime(DateTime.Now.Year, naissance.Month, naissance.Day);
            if(dateAnniv > DateTime.Now)
            {
               age--;
            }
            Console.WriteLine(age + " ans");
        }
        public int Anciennete()
        {
            DateTime embauche = Convert.ToDateTime(this.dateEmbauche);
            int anee = DateTime.Now.Year - embauche.Year;
            DateTime anciennete = new DateTime(DateTime.Now.Year, embauche.Month, embauche.Day);
            if (anciennete > DateTime.Now)
            {
                anee--;
            }
            return anee;
        }

        public void AugmentationDuSalaire()
        {
            
            if (Anciennete() >= 5 || Anciennete() < 10)
            {
                this.salaire = salaire * 1.05;
                Console.WriteLine(this.salaire);
            }
            else if (Anciennete() < 5)
            {
                this.salaire = salaire * 1.02;
                Console.WriteLine(this.salaire);
            }
            else
            {
                this.salaire = salaire * 1.10;
                Console.WriteLine(this.salaire);
            }

        }

        public void AfficherEmployé()
        {
            char[] a = this.prenom.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            Console.WriteLine("Matricule : " + this.matricule);
            Console.WriteLine("NOM Prénom : " + this.nom.ToUpper() + " " + new string(a));
            Console.WriteLine("Age : " + Age());
            Console.WriteLine("Ancienneté : " + Anciennete());

        }
    }
}
