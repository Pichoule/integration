using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Plateforme_Gestion_Client;

namespace Plateforme_Gestion_Client
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Client1_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd = new Window2();
            //wnd.Show();
            wnd.ShowDialog();
            
        }

        private void Client2_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd = new Window2();
            //wnd.Show();
            wnd.ShowDialog();
        }

        private void Deconnexion(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void Supprimer1(object sender, RoutedEventArgs e)
        {

        }

        private void Supprimer2(object sender, RoutedEventArgs e)
        {

        }
    }
}
