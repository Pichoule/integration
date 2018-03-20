using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace integrationProjet
{
    class connexionBDD
    {
        private MySqlConnection connection;

        public void connectBDD()
        {
            initConnexion();
        }

        public void initConnexion()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=integrationprojet; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
    }
}
