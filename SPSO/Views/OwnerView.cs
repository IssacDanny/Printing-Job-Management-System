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
    public partial class OwnerView : Form, IOwnerView
    {
        //Fields
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        //Constructor
        public OwnerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEnvents();
            tabControl1.TabPages.Remove(tabPageOwnerEdit);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEnvents()
        {
            //Edit
            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty); 
                tabControl1.TabPages.Remove(tabPageOwnerInfo);
                tabControl1.TabPages.Add(tabPageOwnerEdit);
                tabPageOwnerEdit.Text = "Edit User Profile";
            };

            //Save
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    tabControl1.TabPages.Remove(tabPageOwnerEdit);
                    tabControl1.TabPages.Add(tabPageOwnerInfo);
                }
                MessageBox.Show(Message);
            };

            //Cancel
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageOwnerEdit);
                tabControl1.TabPages.Add(tabPageOwnerInfo);
            };
        }

        //Property
        public string LastName 
        { 
            get { return textLastName.Text; }
            set { textLastName.Text = value; } 
        }
        public string FirstName 
        { 
            get { return textFirstName.Text; } 
            set {  textFirstName.Text = value; } 
        }
        public string Email 
        { 
            get { return textEmail.Text; } 
            set { textEmail.Text = value; } 
        }
        public string PhoneNumber 
        { get { return textPhoneNumber.Text; } 
            set { textPhoneNumber.Text = value; } 
        }
        public bool IsEdit 
        { 
            get { return isEdit; } 
            set { isEdit = value; } 
        }
        public bool IsSuccessful 
        { 
            get { return isSuccessfull; } 
            set {  isSuccessfull = value; }
        }
        public string Message 
        { 
            get { return message; } 
            set { message = value; } 
        }

        //Events
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetOwnerBindingSource(BindingSource ownerInformation)
        {
            try
            {  
                //Clear textbox
                txtLastName.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();

                //Display Data
                // Set bindings for the properties of OwnerModel
                txtLastName.DataBindings.Add("Text", ownerInformation, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtFirstName.DataBindings.Add("Text", ownerInformation, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtEmail.DataBindings.Add("Text", ownerInformation, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
                txtPhoneNumber.DataBindings.Add("Text", ownerInformation, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        //Singleton pattern (Open a single form instance)
        private static OwnerView instance;
        

        public static OwnerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OwnerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }else
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
