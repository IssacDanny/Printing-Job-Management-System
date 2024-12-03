using SPSO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Presenters
{
    public class PurchasePresenter
    {
        IPurchaseView view;

        public PurchasePresenter(IPurchaseView view)
        {
            this.view=view;

            //Subcribe event handler methodss to view events
            this.view.SaveEvent += Purchase;

            this.view.Show();
        }

        private void Purchase(object sender, EventArgs e)
        {
            view.Message = "Transaction occured successfully";
            view.IsSuccessful = true;
        }
    }
}
