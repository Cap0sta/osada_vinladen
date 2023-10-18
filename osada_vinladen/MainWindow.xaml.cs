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

namespace osada_vinladen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
 
        Anagram ak47 = new Anagram();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ak47;
        }
 
        private void BtnWyslij_Checked(object sender, RoutedEventArgs e)
        {
 
 
                m4a1.Text = (ak47.SprawdzAna());
 
 
 
        }
        void BtnWyslij_Unchecked(object sender, RoutedEventArgs e)
        {
            pierwszy_slot.Text = ("");
            drugi_slot.Text = ("");
        }
 
 
    }
}
