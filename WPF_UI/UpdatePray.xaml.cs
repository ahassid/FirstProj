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
using BL;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for UpdatePray.xaml
    /// </summary>
    public partial class UpdatePray : Window
    {
        BL.BLImp bl;
        BE.Pray p;

        public UpdatePray()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            p = new BE.Pray();

            this.SynagoguecomboBox.ItemsSource = bl.GetAllSynagogues();
            this.SynagoguecomboBox.DisplayMemberPath = "name";

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SynagoguecomboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem c = (ComboBoxItem)SynagoguecomboBox.SelectedItem;
            KindPraycomboBox.ItemsSource = bl.PrayBySynagogue(c);

        }
    }
}
