using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrationToka.Integrationjenkins
{

    class Patient
    {
        public enum Genre { F, M };

        protected string Nom;
        protected string Prenom;
        protected string NumSecu;
        public Genre Sexe;

        protected string Pathologie;
        protected DateTime DerniereVisite;


        public Patient(string nom, string prenom, Genre sexe, string pathologie, DateTime lastVisite)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            GenerateNumSecu(Sexe);
            Pathologie = pathologie;
            DerniereVisite = lastVisite;
        }

        protected void GenerateNumSecu(Genre sexe)
        {
            Random rnd = new Random();

            string num1;
            string num2;
            int mois;
            string num3;
            int departement;
            string num4;

            if (sexe == Genre.F)
            {
                num1 = "2";
                NumSecu += num1;
            }
            else if (sexe == Genre.M)
            {
                num1 = "1";
                NumSecu += num1;
            }

            num2 = rnd.Next(15, 99).ToString();
            NumSecu += num2;

            mois = rnd.Next(1, 12);
            if (mois < 10)
            {
                num3 = "0" + mois.ToString();
                NumSecu += num3;
            }
            else
            {
                num3 = mois.ToString();
                NumSecu += num3;
            }

            departement = rnd.Next(1, 95);
            if (departement == 20)
            {
                departement += 1;
            }
            else if (departement < 10)
            {
                num4 = "0" + departement.ToString();
                NumSecu += num4;
            }
            else
            {
                num4 = departement.ToString();
                NumSecu += num4;
            }

            NumSecu += rnd.Next(10000000, 99999999).ToString();
        }
    }

}
