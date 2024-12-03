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
    public partial class RequestView : Form, IRequestView
    {
        //Fields
        private string message;
        private bool isSuccessful;

        //Constructor
        public RequestView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            tabControl1.TabPages.Remove(tabPageRequestDetail);
            btnClose.Click += delegate { this.Close(); };

            // Set default selection 
            radioButtonDoubleSided.Checked = true;            
            
            
        }

        private void AssociateAndRaiseViewEvent()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                };
            };

            //Add new
            btnAddNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePrintingLog);
                tabControl1.TabPages.Add(tabPageRequestDetail);
                tabPageRequestDetail.Text = "Add new request";
            };

            //Save 
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageRequestDetail);
                    tabControl1.TabPages.Add(tabPagePrintingLog);
                    
                }
                MessageBox.Show(Message);
            };

            //Cancel
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageRequestDetail);
                tabControl1.TabPages.Add(tabPagePrintingLog);
            };

        }

        //Properties
        public int StudentId 
        {
            get
            {
                // Try to parse the text from the text box to an integer
                if (int.TryParse(txtID.Text, out int studentId))
                {
                    return studentId;  // Return the parsed integer
                }
                else
                {
                    throw new InvalidOperationException("Invalid Student ID format.");
                }
            }
            set { txtID.Text = value.ToString(); } 
        }
        public string StudentName 
        { 
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public int PaperSize 
        {
            get { return PaperSizeCB.SelectedIndex; }
            set { PaperSizeCB.SelectedIndex = value; }
        }
        public int PrintType 
        {
            get
            {
                if (radioButtonOneSided.Checked)
                    return 0;
                else if (radioButtonDoubleSided.Checked)
                    return 1;
                else
                    throw new ArgumentException("Invalid print type value."); // throwing an exception if none is selected
            }
            set
            {
                switch (value)
                {
                    case 0:
                        radioButtonOneSided.Checked = true;
                        break;
                    case 1:
                        radioButtonDoubleSided.Checked = true;
                        break;
                    default:
                        throw new ArgumentException("Invalid print type value.");
                }
            }
        }
        public int Quantity 
        {
            get { return (int)numericUpDownQuantity.Value; }
            set { numericUpDownQuantity.Value = value; }
        }
        public int PrintingLocation 
        {
            get { return PrintingLocationCB.SelectedIndex; }
            set { PrintingLocationCB.SelectedIndex = value; }
        }
        public DateTime RequestDate 
        { 
            get { return DateTime.Now; } 
            
        }
        public TimeSpan RequestTime 
        { 
            get { return DateTime.Now.TimeOfDay; }
            
        }
        public string SearchValue 
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }                            
        }
        public bool IsSuccessful 
        { 
            get { return isSuccessful; } 
            set {  isSuccessful = value; }
        }
        public string Message 
        { 
            get { return message; } 
            set { message = value; } 
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetRequestListBindingSource(BindingSource requestList)
        {
            dataGridView1.DataSource = requestList;

            // Set the AutoSizeMode for each column
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Hide the columns you don't want to display
            dataGridView1.Columns["studentId"].Visible = false; // Hide the studentId
            dataGridView1.Columns["studentName"].Visible = false; // Hide the studentName
            dataGridView1.Columns["printingLocation"].Visible = false; // Hide printingLocation
            dataGridView1.Columns["printType"].Visible = false; // Hide printType
        }

        private void PrintingLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
       

            
        }

        private void PaperSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Singleton pattern (Open a single form Instance)
        private static RequestView instance;
        public static RequestView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new RequestView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
