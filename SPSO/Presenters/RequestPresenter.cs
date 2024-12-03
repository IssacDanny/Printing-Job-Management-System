using SPSO.Models;
using SPSO.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSO.Presenters
{
    public class RequestPresenter
    {
        //Fields
        private IRequestView view;
        private IRequestRepository repository;
        private BindingSource requestBindingSource;
        private IEnumerable<RequestModel> requestList;

        //Constructor
        public RequestPresenter(IRequestView view, IRequestRepository repository)
        {
            this.requestBindingSource = new BindingSource();
            this.view=view;
            this.repository=repository;

            //Subcribe event handler methods to view events
            this.view.SearchEvent += SearchRequest;
            this.view.AddNewEvent += AddNewRequest;
            this.view.SaveEvent += SaveRequest;
            this.view.CancelEvent += CancelAction;

            //Load request list view
            LoadAllRequestList();

            //Set pets binding source
            this.view.SetRequestListBindingSource(requestBindingSource);
            
            //Show view
            this.view.Show();
        }

        //Method

        private void LoadAllRequestList()
        {
            requestList = repository.GetAll();
            requestBindingSource.DataSource = requestList;
        }

        private void SearchRequest(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                requestList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                requestList = repository.GetAll();
            }
            requestBindingSource.DataSource = requestList;
        }

        private void AddNewRequest(object sender, EventArgs e)
        {
            return;
        }
        private void SaveRequest(object sender, EventArgs e)
        {
            var model = new RequestModel();
            model.studentId = view.StudentId;
            model.studentName = view.StudentName;
            model.printingLocation = view.PrintingLocation;
            model.paperSize = view.PaperSize;
            model.printType = view.PrintType;
            model.quantity = view.Quantity;
            model.requestDate = view.RequestDate;
            model.requestTime = view.RequestTime;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                repository.Add(model);
                view.Message = "Request added successfully";
                view.IsSuccessful = true;
                LoadAllRequestList();
                CleanviewField();
            }
            catch (Exception ex)
            { 
                    view.IsSuccessful = false;
                    view.Message = ex.Message;
            }
        }

        private void CleanviewField()
        {
            view.StudentId = 0;
            view.StudentName = "";
            view.PrintingLocation = 0;
            view.PaperSize = 0;
            view.PrintType = 0;
            view.Quantity = 0;
            
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewField();
        }
    }
}
