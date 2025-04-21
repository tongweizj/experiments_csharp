using OMSS.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OMSS.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get => _currentViewModel;
            set { _currentViewModel = value; OnPropertyChanged(); }
        }

        public ICommand LoadBasketsCommand { get; }
        public ICommand ShowAddItemViewCommand { get; }

        private readonly ListOrderDetailsViewModel _listViewModel;

        public MainWindowViewModel()
        {
            // 初始化列表视图 VM 并设为当前视图
            _listViewModel = new ListOrderDetailsViewModel();
            CurrentViewModel = _listViewModel;

            // 命令：加载篮子、切换到新增项视图
            LoadBasketsCommand = new RelayCommand(async _ => await _listViewModel.LoadBasketsAsync());
            ShowAddItemViewCommand = new RelayCommand(_ => ShowAddNewItem());

            // 程序启动时先加载一次篮子
            LoadBasketsCommand.Execute(null);
        }

        private void ShowAddNewItem()
        {
            var addVm = new AddNewItemViewModel();

            // 新增成功后，刷新列表并切回列表视图
            addVm.ItemAdded += (s, e) =>
            {
                LoadBasketsCommand.Execute(null);
                CurrentViewModel = _listViewModel;
            };
            // 点击取消，也切回列表视图
            addVm.CancelRequested += (s, e) =>
            {
                CurrentViewModel = _listViewModel;
            };

            CurrentViewModel = addVm;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
