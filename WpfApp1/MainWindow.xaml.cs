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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number1 = "";
        string number2 = "";
        string operation = "";
        int resultat = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void B1_Click(object send,RoutedEventArgs e)
        {

            Button button = (Button)send;
            string nbr = button.Content.ToString();

            if (operation == "")
            {
                number1 += nbr;
                Reponse.Text = number1.ToString();
            }
            else
            {
                number2 += nbr;
                Reponse.Text = number2.ToString();
            }
            
        }
        private void Boperator_Click(object send, RoutedEventArgs e)
        {
            Button button = (Button)send;
            string ope = button.Content.ToString();
            operation = ope;
            Reponse.Text = "";
                
        }

        private void Resultat_Click(object send, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    resultat = (int.Parse(number1)) + (int.Parse(number2));
                    Reponse.Text = resultat.ToString();
                    break;
                case "-":
                    resultat = (int.Parse(number1)) - (int.Parse(number2));
                    Reponse.Text = resultat.ToString();
                    break;
                case "X":
                    resultat = (int.Parse(number1)) * (int.Parse(number2));
                    Reponse.Text = resultat.ToString();
                    break;
                case "%":
                    resultat = (int.Parse(number1)) / (int.Parse(number2));
                    Reponse.Text = resultat.ToString();
                    break;
            }
        }

        private void BClear_Click(object send, RoutedEventArgs e)
        {
            Button button = (Button)send;
            string ope = button.Content.ToString();
            number1 = "";
            number2 = "";
            operation = "";
            Reponse.Text = "0";
        }
        private void Bsigne_Click(object send, RoutedEventArgs e)
        {
            
            if (operation == "")
            { 
                number1 = (-int.Parse(number1)).ToString();
                Reponse.Text = number1;
            }
               

            else
            {
                number2 = (-int.Parse(number2)).ToString();
                Reponse.Text = number2;
            }
                

        }

    }
}
