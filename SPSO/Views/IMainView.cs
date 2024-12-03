using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Views
{
    public interface IMainView
    {
        event EventHandler ShowRequestView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowPurchaseView;
        event EventHandler ShowHomePageView;
    }
}
