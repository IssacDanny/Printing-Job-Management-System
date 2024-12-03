using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSO.Views
{
    public interface IRequestView
    {
        //Properties - Fields
        int StudentId { get; set; }
        string StudentName { get; set; }
        int PaperSize { get; set; }
        int PrintType { get; set; }
        int Quantity { get; set; }
        int PrintingLocation { get; set; }
        DateTime RequestDate { get; }
        TimeSpan RequestTime { get; }

        string SearchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetRequestListBindingSource(BindingSource requestList);
        void Show();
    }
}
