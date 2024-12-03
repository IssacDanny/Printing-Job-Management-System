using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSO.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnRequests.Click += delegate { ShowRequestView?.Invoke(this, EventArgs.Empty); };
            btnOwner.Click += delegate { ShowOwnerView?.Invoke(this, EventArgs.Empty); };
            btnPurchase.Click += delegate { ShowPurchaseView?.Invoke(this, EventArgs.Empty); };
            btnHomePage.Click += delegate { ShowHomePageView?.Invoke(this, EventArgs.Empty); };


        }

        public event EventHandler ShowRequestView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowPurchaseView;
        public event EventHandler ShowHomePageView;

       
    }
}
