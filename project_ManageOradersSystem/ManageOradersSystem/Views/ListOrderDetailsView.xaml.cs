using ManageOradersSystem.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManageOradersSystem.Views
{
    /// <summary>
    /// Interaction logic for DataGridTab.xaml
    /// </summary>
    public partial class DataGridTab : UserControl
    {
        private MainWindowViewMode _mainWindowViewMode;
        public DataGridTab()
        {
            InitializeComponent();
            DataContext = MainWindowViewMode.Instance;
            // 当窗口加载完成（Loaded 事件）时，执行一个异步的事件处理器
            Loaded += async (s, e) =>
            {
                try
                {
                    // 异步调用 MainWindowViewMode 的单例实例的初始化方法
                    await MainWindowViewMode.Instance.InitializeAsync();
                }
                catch (Exception ex)
                {
                    // 如果初始化过程中发生异常，则显示一个错误提示框，提示用户“数据加载失败”并附带具体异常信息
                    MessageBox.Show($"数据加载失败: {ex.Message}");
                }
            };
        }
 
    }
}
