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
using BE;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        BL.IBL bl;
        BE.Synagogue s;

        public Adding()
        {
            InitializeComponent();
            s = new BE.Synagogue();

            this.NosahcomboBox.ItemsSource = Enum.GetValues(typeof(BE.Nosah));
        }

        private void SunagogueButton_Click(object sender, RoutedEventArgs e)
        {
            s.name = textBox.Text;
            s.address = textBox1.Text;
            s.notes = textBox2.Text;
          //  s.nosah = (ComboBoxItem)NosahcomboBox.SelectedItem;
            
        }

        private void NosahcomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
