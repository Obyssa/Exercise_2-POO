using System;
using System.Collections.Generic;
using System.Text;

namespace classe_exo2
{
    class Livre
    {


        private string titre;
        private string auteur;
        private int prix;

        public Livre(string titre, string auteur, int prix)
        {

            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;

        }


        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }

        }

        public string Auteur
        {

            get
            {

                return auteur;

            }
            set
            {
                auteur = value;
            }

        }

        public int Prix
        {
            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }

        public string Afficher()
        {
            return Titre + " " + Auteur + " " + Prix;
        }


    }
}
