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

namespace ProgPoeTest
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

        private void Replace_Click(object sender, RoutedEventArgs e)
        {
            // Takes the user to ReplacingBooks Game
            ReplaceBooks replace = new ReplaceBooks();
            this.Close();
            replace.Show();
        }

        private void Identify_Click(object sender, RoutedEventArgs e)
        {
            // Takes the user to IdentifyingAreas Game
            IdentifyingAreas replace = new IdentifyingAreas();
            this.Close();
            replace.Show();
        }

        private void Call_Click(object sender, RoutedEventArgs e)
        {
            //informs user that the button does nothing at the moment.
            FindingCallNumbers replace = new FindingCallNumbers();
            this.Close();
            replace.Show();
        }

       
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Closes the app
            this.Close();
        }
    }
}
