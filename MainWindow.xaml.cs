/*
 * Aiden Jolley Ruhn
 * Febuary 9, 2018
 * Output Program
 * User enters name and program outputs Hello name!
 */ 
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

namespace u1_02_AidenJrOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btngreeting_Click(object sender, RoutedEventArgs e)
        {
            lbloutput.Content = "Hello, " + entryName.Text;
        }
    }
}
