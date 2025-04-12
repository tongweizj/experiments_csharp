using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for DataGridTab.xaml
    /// </summary>
    public partial class DataGridTab : UserControl
    {
        public DataGridTab()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // 创建示例数据
            var people = new List<Person>
        {
                new Person { Id = 1, Name = "张三", Age = 28, Occupation = "软件工程师" },
                new Person { Id = 2, Name = "李四", Age = 32, Occupation = "项目经理" },
                new Person { Id = 3, Name = "王五", Age = 25, Occupation = "UI设计师" },
                new Person { Id = 4, Name = "赵六", Age = 40, Occupation = "系统架构师" },
                new Person { Id = 5, Name = "钱七", Age = 35, Occupation = "产品经理" }
            };

            // 绑定数据到DataGrid
            dataGrid.ItemsSource = people;
        }
    }
}
// 数据模型类
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
}