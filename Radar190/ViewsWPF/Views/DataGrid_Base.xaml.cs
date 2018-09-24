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

namespace ViewsWPF.Views
{
    /// <summary>
    /// Interaction logic for DataGrid_Base.xaml
    /// </summary>
    public partial class DataGrid_Base : Window
    {
        public DataGrid_Base()
        {
            InitializeComponent();
        }

        private void wwBase_Loaded(object sender, RoutedEventArgs e)
        {
            Controller.DenunciaController denunController = new Controller.DenunciaController();

            dgBaseDenuncia.ItemsSource = denunController.ListDenuncia();
        }
    }
}
