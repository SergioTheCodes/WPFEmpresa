using BusinessLogic.Interfaces;
using System;
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
    using BusinessLogic;
    using Models;
    /// <summary>
    /// Lógica de interacción para UpdateUser.xaml
    /// </summary>
    public partial class UpdateUser : Page
    {
        private BLUser _logic = new BLUser();
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new Users
            {
                Nombre = name.Text,
                Documento = dni.Text,
                TipoDocumento1 = Convert.ToInt32(type.Text),
                Cargo = position.Text,
                area = area.Text,

            };

            try
            {
                _logic.UpdateUser(user);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
