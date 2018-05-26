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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plateforme_Gestion_Client
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd1 = new Window1();
            wnd1.ShowDialog();
        }

        private void MdpOublie(object sender, RoutedEventArgs e)
        {
            Window4 wnd4 = new Window4();
            wnd4.ShowDialog();
        }

        private void PageInscription(object sender, RoutedEventArgs e)
        {
            Window3 wnd3 = new Window3();
            wnd3.ShowDialog();
        }

        private void Affectation_Click(object sender, RoutedEventArgs e)
        {
            Window5 wnd5 = new Window5();
            wnd5.ShowDialog();
        }
    }
}
