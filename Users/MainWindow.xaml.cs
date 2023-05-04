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
using Users.Views;

namespace Users
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

        private void btnToUsuariosPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddUser();
        }

        private void btnToAreaPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UpdateUser();
        }

        private void Main_LoadCompleted(object sender, NavigationEventArgs e)
        {
            Main.Content = new ListUsers();
        }
    }
}
