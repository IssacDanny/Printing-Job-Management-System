using SPSO.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSO.Presenters
{
    public class HomePagePresenter
    {
        IHomePage view;

        public HomePagePresenter(IHomePage view)
        {
            this.view=view;

            this.view.Show();
        }
    }
}
