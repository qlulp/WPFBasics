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

namespace WpfBasics
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

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckBox.IsChecked = AssemblyCheckBox.IsChecked = PlasmaCheckBox.IsChecked =
            LaserCheckBox.IsChecked = PurchaseCheckBox.IsChecked = LaserCheckBox.IsChecked =
            LatheCheckBox.IsChecked = DrillCheckBox.IsChecked = FoldCheckBox.IsChecked = 
            RollCheckBox.IsChecked = SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LengthTextBox.Text += ((CheckBox)sender).Content;
        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteTextBox == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedItem;

            NoteTextBox.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_SelectionChanged(FinishComboBox, null);
        }

        private void SupplierNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MassTextBox.Text = SupplierNameTextBox.Text;
        }
    }
}
