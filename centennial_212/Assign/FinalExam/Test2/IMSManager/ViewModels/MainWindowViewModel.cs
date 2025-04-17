using IMSManager.Command;
using System.Windows;

namespace IMSManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _CurrentViewModel;

        ListAllPoliciesViewModel _listViewModel = new ListAllPoliciesViewModel();
        AddNewPolicyViewModel _addViewModel = new AddNewPolicyViewModel();

        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                SetProperty(ref _CurrentViewModel, value);
            }
        }

        public DelegateCommand View1Command { get; set; }
        public DelegateCommand View2Command { get; set; }

        public DelegateCommand ExitCommand { get; set; }

        public MainWindowViewModel()
        {
            // finish the constructor

            CurrentViewModel = _listViewModel;
        }

        private void ShowListview()
        {
            CurrentViewModel = _listViewModel;
        }


        private void ShowAddView()
        {
            CurrentViewModel = _addViewModel;
           
        }

        private void ExitApp()
        {
            Application.Current.Shutdown();
        }
    }
}
