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

            Loaded += async (s, e) =>
            {
                try
                {
                    await MainWindowViewMode.Instance.InitializeAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"数据加载失败: {ex.Message}");
                }
            };
        }
 
    }
}
