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
    /// Interaction logic for ProductTab.xaml
    /// </summary>
    public partial class ProductTab : UserControl
    {
        private AddNewItemViewModel _addNewItemViewModel;
        private MainWindowViewMode _mainWindowViewMode;

        public ProductTab()
        {
            InitializeComponent();
            _addNewItemViewModel = new AddNewItemViewModel();
            _mainWindowViewMode = MainWindowViewMode.Instance;
            BindComboBoxes();
            DataContext = this;
        }

        private void BindComboBoxes()
        {
            // 将viewModel中的baskets 数据，绑定给combobox
            var basketList = _mainWindowViewMode.baskets.ToList();
            BasketComboBox.ItemsSource = basketList;
            BasketComboBox.DisplayMemberPath = "NameShopper";
            BasketComboBox.SelectedValuePath = "IdBasket";

            var productsList = _addNewItemViewModel.products;
            ProductComboBox.ItemsSource = productsList;
           
            ProductComboBox.SelectedValuePath = "IdProduct";
        }


        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // 验证输入
            if (BasketComboBox.SelectedItem == null)
            {
                ErrorMessageText.Text = "Please select an Basket";
                return;
            }

            if (ProductComboBox.SelectedItem == null)
            {
                ErrorMessageText.Text = "Please select a Product";
                return;
            }

            // 验证数量输入
            if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                ErrorMessageText.Text = "Please enter quantity";
                return;
            }

            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity < 1)
            {
                ErrorMessageText.Text = "Quantity must be a positive integer";
                return;
            }

            // 可选：添加上限检查
            if (quantity > 100) // 假设最大100
            {
                ErrorMessageText.Text = "Quantity cannot exceed 100";
                return;
            }
            byte num = byte.Parse(QuantityTextBox.Text);

            if (!int.TryParse(QuantityTextBox.Text, out int quantitytemp) || quantity <= 0)
            {
                ErrorMessageText.Text = "Please enter a valid quantity";
                return;
            }

            // 获取选中的订单和商品
            var selectedBasket = (BasketViewModel)BasketComboBox.SelectedItem;
            var selectedProduct = (ProductViewModel)ProductComboBox.SelectedItem;

            // 在实际应用中，这里会调用服务或数据库操作
            _addNewItemViewModel.updateBasket(selectedBasket, selectedProduct, num);

            // 显示成功消息
            MessageBox.Show($"Successfully added {quantity}  {selectedProduct.ProductName} to basket {selectedBasket.IdBasket}",
                            "Operation successful",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

            // 重置表单
            ResetForm();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            BasketComboBox.SelectedIndex = -1;
            ProductComboBox.SelectedIndex = -1;
            QuantityTextBox.Text = "1";
            ErrorMessageText.Text = string.Empty;
            _mainWindowViewMode.SelectedBasket = null;
        }
    }
}

