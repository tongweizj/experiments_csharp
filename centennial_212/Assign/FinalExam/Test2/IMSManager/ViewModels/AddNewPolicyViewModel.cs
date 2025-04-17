using IMSLibrary.Models;
using IMSManager.Command;
using IMSManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;


namespace IMSManager.ViewModels
{
    public class AddNewPolicyViewModel: ViewModelBase
    {
        // add necessary properties here 








        public DelegateCommand AddNewItemCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
       
        public string ID { get; set; }
        public DateTime StartDate { get; set; }

        public Decimal Premium { get; set; }
        public String Insured { get; set; }
        public AddNewPolicyViewModel()
        {
            AddNewItemCommand = new DelegateCommand(AddNewItem);
            CancelCommand = new DelegateCommand(Clear);

            // finish the constructor 



        }


        private void AddNewItem()
        {
            //finish this method
            
        }

        private void Clear()
        {
            
        }

    }
}
