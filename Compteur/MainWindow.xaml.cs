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

namespace Compteur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _compteur;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Content.ToString())
            {
                case "+":
                    _compteur ++ ;
                    if (_compteur == 9)
                    {
                        plus.IsEnabled = false;
                        moins.IsEnabled = true;
                    }
                    else
                    {
                        plus.IsEnabled = true;
                        moins.IsEnabled = true;
                    }
                        
                    affichage.Text = _compteur.ToString();
                    break;
                case "-":
                    _compteur -- ;
                    if (_compteur == 0)
                    {
                        button.IsEnabled = false;
                        plus.IsEnabled = true;
                    }
                    else
                    {
                        plus.IsEnabled = true;
                        moins.IsEnabled = true;
                    }
                    affichage.Text = _compteur.ToString();
                    break;
            }
        }
    }
}
