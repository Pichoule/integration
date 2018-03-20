using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plateforme_Gestion_Client
{
    class Infirmiere
    {

        protected string Nom;
        protected string Prenom;

        protected string Login;
        protected string Mdp;

        public List<Patient> ListPatients { get; set; }

        public Infirmiere(string nom, string prenom, string login, string mdp)
        {
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Mdp = mdp;
        }

        protected void CreerPatient()
        {
            string name = Console.ReadLine();
            string firstname = Console.ReadLine();
            string numberSecu = Console.ReadLine();
            Patient.Genre sex = 0;
            string pathology = Console.ReadLine();
            DateTime lastVisit = DateTime.Parse("04/04/2018");

            Patient newPatient = new Patient(name, firstname, sex, pathology, lastVisit);
        }


    }
}