using BusinessLogic;
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

namespace Users.Views
{
    using Models;
    /// <summary>
    /// Lógica de interacción para AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        BLUser _logic = new BLUser();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new Users
            {
                Nombre = nombre.Text,
                Documento = dni.Text,
                TipoDocumento1 = Convert.ToInt32(tipodni.Text),
                Cargo = posicion.Text
            };
            try
            {
                _logic.AddUser(user);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
