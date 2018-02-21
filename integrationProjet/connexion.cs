using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace integrationToka.Integrationjenkins
{
    class Connexion
    {

        public List<Infirmiere> ListInfirmiere { get => ListInfirmiere; set => ListInfirmiere = value; }

        public void entrerInfirmiereRegister()
        {
            string login = Console.ReadLine();
            string mdp = Console.ReadLine();
            string nom = Console.ReadLine();
            string prenom = Console.ReadLine();

            register(login, mdp, nom, prenom);
        }

        protected void register(string login, string mdp, string nom, string prenom)
        {
            ListInfirmiere.Add(login, mdp, nom, prenom);
        }

        protected void connexion()
        {
            string login = Console.ReadLine();
            string mdp = Console.ReadLine();

            bool droitConnexion = false;
            foreach (var infirmiere in ListInfirmiere)
            {
                if (ListInfirmiere.login == login & ListInfirmiere.mdp == mdp)
                {
                    droitConnexion = true;
                }
            }
        }
    }
}