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
//---------------------------------------
using System.ComponentModel;

namespace _04_05SortDescriptionListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbxOrdenar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Al seleccionar una opcion del combobox
            lbxMiListBox.Items.SortDescriptions.Clear();//coger propiedad sort con la lista de criterios de ordenadcion y la vacia (no hay criterio de irdenacion)
            if (cbxOrdenar.SelectedIndex == 0) //me refiero al ascendente
            {
                lbxMiListBox.Items.SortDescriptions.Add(new SortDescription("Text", ListSortDirection.Ascending));
            }
            if (cbxOrdenar.SelectedIndex == 1)
            {
                lbxMiListBox.Items.SortDescriptions.Add(new SortDescription("Text", ListSortDirection.Descending));
            }
        }

        private void chkOtro_Click(object sender, RoutedEventArgs e)
        {
            if (chkOtro.IsChecked)
            {
                MessageBox.Show("SI");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }
    }
}
