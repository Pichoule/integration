using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace integrationProjet
{
    class connexionBDD
    {
        private SqlConnection connection;

        public void connectBDD()
        {
            initConnexion();
        }

        public void initConnexion()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=integrationprojet; UID=root; PASSWORD=";
            this.connection = new SqlConnection(connectionString);
            try
            {
                connection.Open(); // ouverture de la connection
                var MyAdapter = new SqlDataAdapter("SELECT puis reste de la requete", connection);
                MyAdapter.Fill(MyDataSet, "NomTable");// dataset rempli avec le resultat du dessus
                MyDataGrid.DataSource = MyDataSet;// Ici MyDataGrid = le nom du private System.Windows.Forms.DataGrid utilisé
                MyDataGrid.DataMember = "NomTable";// Ici MyDataGrid = le nom du private System.Windows.Forms.DataGrid utilisé
                connection.Close();// fermeture de la connection
            }
            catch (SqlException e)
            {
                object MessageBoxIcon = null;
                MessageBox.Show("Erreur SQL:\n" + e.Message, "Erreur", MessageBoxButton.OK);
            }
        }
    }
}
