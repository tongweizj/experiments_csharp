using IMSLibrary.Models;
using IMSManager.DataAccess;
using IMSManager.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace IMSManager.ViewModels
{
    public class ListAllPoliciesViewModel: ViewModelBase
    {
        // finish the class 
        //DBManager _dataProvider = new DBManager();

        //List<AgentComboBoxModel> agentList = _dataProvider.GetAgents();

        private readonly DBManager _dataProvider;
        private List<AgentComboBoxModel> agentList;



        private ObservableCollection<AgentComboBoxModel> _agentList = new ObservableCollection<AgentComboBoxModel>();
        public ObservableCollection<AgentComboBoxModel> AgentList
        {
            get => _agentList;
            set => SetProperty(ref _agentList, value);
        }


        private AgentComboBoxModel? _selectedAgent;


        public AgentComboBoxModel? SelectedAgent
        {
            get => _selectedAgent;
            set => SetProperty(ref _selectedAgent, value);
        }

        private PolicyDetails _policyDetailsContents;

        public PolicyDetails? PolicyDetailsContents
        {
            get => _policyDetailsContents;
            set => SetProperty(ref _policyDetailsContents, value);
        }
        public ListAllPoliciesViewModel()
        {
            _dataProvider = new DBManager();
            agentList = _dataProvider.GetAgents(); 
            
        }
        

    }
}
