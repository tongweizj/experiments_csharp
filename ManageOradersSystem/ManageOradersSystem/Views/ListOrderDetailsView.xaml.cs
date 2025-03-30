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
            _mainWindowViewMode = MainWindowViewMode.Instance;
            DataContext = _mainWindowViewMode;

            BindComboBoxes();
        }
        private void BindComboBoxes()
        {
            // 将viewModel中的baskets 数据，绑定给combobox
            var basketList = _mainWindowViewMode.baskets.ToList();
            BasketComboBox.ItemsSource = basketList;
            BasketComboBox.DisplayMemberPath = "NameShopper";
            BasketComboBox.SelectedValuePath = "IdBasket";
        }
        private void BasketComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 获取选中的项
            var selectedBasket = BasketComboBox.SelectedItem as BasketViewModel;

            // 在这里执行您的方法
            if (selectedBasket != null)
            {
                // 在这里执行您的方法
                _mainWindowViewMode.SelectedBasket = selectedBasket;

            }

        }
    }
}
