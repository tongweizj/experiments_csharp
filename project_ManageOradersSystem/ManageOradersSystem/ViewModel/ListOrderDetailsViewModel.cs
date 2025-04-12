using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.ViewModel
{
    class ListOrderDetailsViewModel: ViewModelBase
    {
        private MainWindowViewMode _mainWindowViewMode;

        // 单例实现
        private static readonly Lazy<ListOrderDetailsViewModel> _instance =
            new Lazy<ListOrderDetailsViewModel>(() => new ListOrderDetailsViewModel());

        public static ListOrderDetailsViewModel Instance => _instance.Value;


        // 构造器
        private ListOrderDetailsViewModel()
        {
            _mainWindowViewMode = MainWindowViewMode.Instance;
        }



   







   

    }

      
    
}
