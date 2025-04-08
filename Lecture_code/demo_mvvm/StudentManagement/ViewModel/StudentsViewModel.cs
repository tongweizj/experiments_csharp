using StudentManagement.Data;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// 用于管理学生数据，并支持 WPF/MVVM 数据绑定

namespace StudentManagement.ViewModel
{
    public class StudentsViewModel : ViewModelBase
    {
        private StudentItemViewModel? _selectedStudent;

        // ObservableCollection<T>：
        // 动态集合，当元素增删时，自动通知 UI 更新
        // 例如绑定到 ListBox 或 DataGrid
        // 存储的是 StudentItemViewModel：
        // 每个学生条目由 StudentItemViewModel 包装，实现业务逻辑与 UI 解耦。
        public ObservableCollection<StudentItemViewModel> students { get; } = new();

        public StudentsViewModel()
        {
            // 构造器
            //  获取原始学生数据（可能是数据库、API 或本地文件）
            var rawData = DataProvider.GetData();
            if (rawData is not null)
            {
                foreach (var student in rawData)
                {
                    // 将原始数据 Student 转换为 StudentItemViewModel，并添加到集合中。
                    students.Add(new StudentItemViewModel(student));
                }
            }
        }

        // 当前选中学生
        // 双向绑定：
        //通常与 UI 控件（如 ListBox.SelectedItem）绑定，当用户选择学生时更新。
        //属性变更通知：
        //通过 RaisePropertyChanged() 通知 UI 更新。
        public StudentItemViewModel? SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                RaisePropertyChanged();
            }
        }

        // 创建一个默认学生对象（Student）
        // 包装为 StudentItemViewModel
        // 添加到集合（自动触发 UI 更新）
        // 设置为当前选中项（触发 SelectedStudent 变更通知）。
        internal void Add()
        {
            var student = new Student { FirstName = "New", LastName="New",Program="New Program" };
            var viewModel = new StudentItemViewModel(student);
            students.Add(viewModel);
            SelectedStudent = viewModel;
        }
    }
}
