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
        BL.BLImp bl;
        BE.Synagogue s;

        public Adding()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            s = new BE.Synagogue();

            this.NosahcomboBox.ItemsSource = Enum.GetValues(typeof(BE.Nosah));
        }

        private void SunagogueButton_Click(object sender, RoutedEventArgs e)
        {
            s.name = textBox.Text;
            s.address = textBox1.Text;
            s.notes = textBox2.Text;
            s.nosah = (BE.Nosah)NosahcomboBox.SelectedValue;

            bl.addSynagogue(s);
            MessageBoxResult message = MessageBox.Show("Synagogue Added Successfully!");
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
