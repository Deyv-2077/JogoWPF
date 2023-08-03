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

namespace Jogo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int txtBoxTotal;

        public MainWindow()
        {
            InitializeComponent();

            txtBoxValores.Text = "40";
            txtBoxTotal = 0;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {



        }

        private void AlterarNumero()
        {
            if (txtBoxTotal == 40)
            {
                txtBoxValores.Text = "15";
                if (txtBoxValores.Text == "15")
                {

                    button1.Content = "7";
                    button2.Content = "8";
                    button3.Content = "6";

                }
            }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxValores.Text == "40")
            {
                int txtBox1 = 10;
                txtBoxTotal += txtBox1;

                if (txtBoxTotal == 30)
                {
                    txtBoxTotal += txtBox1;
                    AlterarNumero();
                }

            }
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxValores.Text == "40")
            {
                int txtBox2 = 20;
                if (txtBoxTotal == 10)
                {
                    txtBoxTotal += txtBox2;
                    AlterarNumero();
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxValores.Text == "40")
            {
                int txtBox3 = 30;
                if (txtBoxTotal == 10)
                {
                    txtBoxTotal += txtBox3;
                    AlterarNumero();
                }
            }
        }
    }
}
