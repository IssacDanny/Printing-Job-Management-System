using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPSO.Views;
using SPSO.Models;
using SPSO._Repositories;

namespace SPSO.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView=mainView;
            this.sqlConnectionString=sqlConnectionString;
            this.mainView.ShowRequestView += ShowRequestsView;
            this.mainView.ShowOwnerView += ShowOwnerView;
            this.mainView.ShowPurchaseView += ShowPurchaseView;
            this.mainView.ShowHomePageView += ShowHomePageView;


        }

        private void ShowHomePageView(object sender, EventArgs e)
        {
            IHomePage view = HomePageView.GetInstance((MainView)mainView);
            new HomePagePresenter(view);
        }

        private void ShowPurchaseView(object sender, EventArgs e)
        {
            IPurchaseView view = PurchaseView.GetInstance((MainView)mainView);
            new PurchasePresenter(view);
        }

        private void ShowOwnerView(object sender, EventArgs e)
        {
            IOwnerView view = OwnerView.GetInstance((MainView)mainView);
            IOwnerRepository repository = new OwnerRepository(sqlConnectionString);
            new OwnerPresenter(view, repository);
        }

        private void ShowRequestsView(object sender, EventArgs e)
        {
            IRequestView view = RequestView.GetInstance((MainView)mainView);
            IRequestRepository repository = new RequestRepository(sqlConnectionString);
            new RequestPresenter(view, repository);
        }
    }
}
