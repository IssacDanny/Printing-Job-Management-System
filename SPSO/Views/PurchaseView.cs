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
    public partial class PurchaseView : Form, IPurchaseView
    {
        //Fields
        private string message;
        private bool isSuccessfull;

        public PurchaseView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEnvents();
            btnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEnvents()
        {
            //Save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);                
                MessageBox.Show(Message);
            };
        }

        public bool IsSuccessful
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //Events
        public event EventHandler SaveEvent;



        //Singleton pattern (Open a single form instance)
        private static PurchaseView instance;


        public static PurchaseView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PurchaseView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
