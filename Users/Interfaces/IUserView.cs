using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users.Interfaces
{
    public interface IUserView
    {
        int idUser { get; set; }
        string nombre { get; set; }
        string documento { get; set; }
        string cargo { get; set; }
        int TipoDocumento { get; set; }

        event EventHandler AddNewUserEvent;
        event EventHandler RemoveUserEvent;
        event EventHandler UpdateUserEvent;
        event EventHandler DeleteUserEvent;
        event EventHandler CancelEvent;

        void SetUserListSource(BindingSource userList);
        void Show();
    }
}
