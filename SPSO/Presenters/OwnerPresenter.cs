using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPSO.Models;
using SPSO.Views;

namespace SPSO.Presenters
{
    public class OwnerPresenter
    {
        //Fields
        private IOwnerView view;
        private IOwnerRepository repository;
        private BindingSource ownerBindingSource;
        private IEnumerable<OwnerModel> OwnerInfo;

        //Constructor
        public OwnerPresenter(IOwnerView view, IOwnerRepository repository)
        {
            this.ownerBindingSource = new BindingSource();
            this.view=view;
            this.repository=repository;

            //Subcribe event handler methodss to view events
            this.view.EditEvent += EditOwner;
            this.view.SaveEvent += SaveOwnerInfo;
            this.view.CancelEvent += CancelAction;

            //Load Onwer infomation
            LoadOwnerInfo();

            //Set user binding source
            this.view.SetOwnerBindingSource(ownerBindingSource);        

            this.view.Show();
        }

        //Methods
        private void LoadOwnerInfo()
        {
            OwnerInfo = repository.GetData();
            ownerBindingSource.DataSource = OwnerInfo;
           
        }

        private void EditOwner(object sender, EventArgs e)
        {
            var owner = (OwnerModel)ownerBindingSource.Current;
            view.FirstName = owner.FirstName;
            view.LastName = owner.LastName;
            view.Email = owner.Email;
            view.PhoneNumber = owner.PhoneNumber;
            view.IsEdit = true;            
        }

        private void SaveOwnerInfo(object sender, EventArgs e)
        {
            var model = new OwnerModel();
            model.LastName = view.LastName;
            model.FirstName = view.FirstName;
            model.Email = view.Email;
            model.PhoneNumber = view.PhoneNumber;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                repository.Edit(model);
                view.Message = "User profile edited successfully";
                view.IsSuccessful = true;
                LoadOwnerInfo();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.FirstName = "";
            view.LastName = "";
            view.Email = "";
            view.PhoneNumber = "";
            
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
