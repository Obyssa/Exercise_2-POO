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
        private int salaire;
        


        public Employe(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, int salaire)
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
        public int Salaire
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
        
        public void Age(string dateNaissance)
        {
            DateTime naissance = Convert.ToDateTime(dateNaissance);
            int age = DateTime.Now.Year - naissance.Year;
            DateTime dateAnniv = new DateTime(DateTime.Now.Year, naissance.Month, naissance.Day);
            if(dateAnniv > DateTime.Now)
            {
                age--;
            }
        }


    }
}
