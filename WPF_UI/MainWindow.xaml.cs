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
using BL;


namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBL bl;
        public MainWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

        }

        private void SynagogueAdditionButton_Click(object sender, RoutedEventArgs e)
        {
            var v = new Adding();
            v.ShowDialog();
        }

        private void PrayUpdationButton_Click(object sender, RoutedEventArgs e)
        {
            var v = new AddingPray();
            v.ShowDialog();
        }

        private void SynagogueUpdationButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var v = new UpdatePray();
            v.ShowDialog();
        }
    }
}
