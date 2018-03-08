using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plateforme_Gestion_Client
{
    class Infirmiere
    {
        protected enum Genre { F, M };

        protected string Nom;
        protected string Prenom;

        protected string Login;
        protected string Mdp;

        public List<Patient> ListPatients { get; set; }

        protected void CreerPatient()
        {
            String name = Console.ReadLine;
            String firstname = Console.ReadLine;
            String numberSecu = Console.ReadLine;
            Genre sex = Console.ReadLine;
            String pathology = Console.ReadLine;
            DateTime lastVisit = Console.ReadLine;

            protected Patient newPatient = new Patient(name, firstname, sexe, pathology, lastVisit);
    }
}
}
