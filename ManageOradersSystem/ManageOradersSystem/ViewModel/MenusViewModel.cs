using ManageOradersSystem.Model;
using ManageOradersSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.ViewModel
{
    class MenusViewModel: ViewModelBase
    {
        private MenuItemViewModel? _selectedMenu;


        // ObservableCollection<T>：
        // 动态集合，当元素增删时，自动通知 UI 更新
        // 例如绑定到 ListBox 或 DataGrid
        // 存储的是 StudentItemViewModel：
        // 每个学生条目由 StudentItemViewModel 包装，实现业务逻辑与 UI 解耦。
        public ObservableCollection<MenuItemViewModel> menus { get; } = new();

        public MenusViewModel()
        {
            // 构造器
            //  获取原始学生数据（可能是数据库、API 或本地文件）
            var rawData = DataProvider.GetData();
            if (rawData is not null)
            {
                foreach (var menu in rawData)
                {
                    // 将原始数据 Student 转换为 StudentItemViewModel，并添加到集合中。
                    menus.Add(new MenuItemViewModel(menu));
                }
            }
        }

        // 当前选中学生
        // 双向绑定：
        //通常与 UI 控件（如 ListBox.SelectedItem）绑定，当用户选择学生时更新。
        //属性变更通知：
        //通过 RaisePropertyChanged() 通知 UI 更新。
        public MenuItemViewModel? SelectedMenu
        {
            get => _selectedMenu;
            set
            {
                _selectedMenu = value;
                RaisePropertyChanged();
            }
        }

        // 创建一个默认学生对象（Student）
        // 包装为 StudentItemViewModel
        // 添加到集合（自动触发 UI 更新）
        // 设置为当前选中项（触发 SelectedStudent 变更通知）。
        internal void Add()
        {
            var menu = new Menu { Category = "New", Name = "New", Price = 0.0M };
            var viewModel = new MenuItemViewModel(menu);
            menus.Add(viewModel);
            SelectedMenu = viewModel;
        }
    }
}
