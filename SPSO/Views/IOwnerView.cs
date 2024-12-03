using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSO.Views
{
    public interface IOwnerView
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Method
        void SetOwnerBindingSource(BindingSource ownerInformation);
        void Show();
    }
}
