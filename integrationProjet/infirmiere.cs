using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrationToka.Integrationjenkins
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
            string name = Console.ReadLine();
            string firstname = Console.ReadLine();
            string numberSecu = Console.ReadLine();
            Genre sex = Console.ReadLine();
            string pathology = Console.ReadLine();
            DateTime lastVisit = Console.ReadLine();

            protected Patient newPatient = new Patient(name, firstname, sexe, pathology, lastVisit);
    }
}
}
