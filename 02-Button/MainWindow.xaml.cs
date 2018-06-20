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

namespace _02_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            text1.Text += $"{i++} ";
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            var checks = Parent1.Children;
            foreach (var elem in checks)
            {
                var cb = (CheckBox)elem as CheckBox;
                if(cb!=null)
                {
                    string s = $"{cb.Content.ToString()} => {cb.IsChecked}";
                    MessageBox.Show(s);
                }
              
            }
        }
    }
}
