using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Views
{
    public interface IPurchaseView
    {

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SaveEvent;

        //Method
        void Show();
    }
}
