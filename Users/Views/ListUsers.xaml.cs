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
    /// <summary>
    /// Lógica de interacción para ListUsers.xaml
    /// </summary>
    public partial class ListUsers : Page
    {
        private BLUser _logic = new BLUser();
        public ListUsers()
        {
            InitializeComponent();
        }        
    }
}
