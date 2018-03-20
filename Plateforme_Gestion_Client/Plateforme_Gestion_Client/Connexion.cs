using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Plateforme_Gestion_Client
{
    class Connexion
    {

        public List<Infirmiere> ListInfirmiere { get => ListInfirmiere; set => ListInfirmiere = value; }

        public void AddInfirmière()
        {
            string login = Console.ReadLine();
            string mdp = Console.ReadLine();
            string nom = Console.ReadLine();
            string prenom = Console.ReadLine();

            Infirmiere newInfirmière = new Infirmiere(nom, prenom, login, mdp);

            ListInfirmiere.Add(newInfirmière);
        }



    }
}
