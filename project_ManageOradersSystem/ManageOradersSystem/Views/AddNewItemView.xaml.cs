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
    /// 商品管理选项卡
    /// 功能：提供界面用于选择订单、商品和数量，并将商品添加到指定订单
    /// </summary>
    public partial class ProductTab : UserControl
    {
        private AddNewItemViewModel _viewModel;

        /// <summary>
        /// 构造函数
        /// </summary>
        public ProductTab()
        {
            InitializeComponent();
            _viewModel = new AddNewItemViewModel();
            DataContext = _viewModel;

            // 注册Loaded事件异步加载数据
            Loaded += async (s, e) =>
            {
                try
                {
                    await InitializeAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"初始化失败: {ex.Message}", "错误",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            };
        }
        /// <summary>
        /// 异步初始化控件
        /// </summary>
        private async Task InitializeAsync()
        {
            // 绑定ComboBox数据源
            BasketComboBox.ItemsSource = MainWindowViewMode.Instance.Baskets;
            BasketComboBox.DisplayMemberPath = "NameShopper";  // 显示购物篮标识
            BasketComboBox.SelectedValuePath = "IdBasket";   // 实际绑定值

            // 确保产品数据已加载
            await _viewModel.InitializeProductsAsync();
            ProductComboBox.ItemsSource = _viewModel.Products;
            ProductComboBox.SelectedValuePath = "IdProduct";
        }

        /// <summary>
        /// 提交按钮点击事件
        /// </summary>
        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // 验证输入
            if (!ValidateInputs(out var quantity))
                return;

            // 获取选中的订单和商品
            var selectedBasket = (BasketViewModel)BasketComboBox.SelectedItem;
            var selectedProduct = (ProductViewModel)ProductComboBox.SelectedItem;

            // 更新ViewModel属性
            _viewModel.SelectedBasket = selectedBasket;
            _viewModel.SelectedProduct = selectedProduct;
            _viewModel.Quantity = quantity;

            // 执行数据库操作
            var success = await _viewModel.UpdateBasketAsync();
            if (success)
            {
                MessageBox.Show($"Successfully added {quantity}  {selectedProduct.ProductName}  to basket {selectedBasket.IdBasket}",
                    "Operation successful",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                ResetForm();
            }
        }

        /// <summary>
        /// 验证用户输入有效性
        /// </summary>
        /// <param name="quantity">输出解析后的数量</param>
        /// <returns>是否通过验证</returns>
        private bool ValidateInputs(out byte quantity)
        {
            quantity = 0;

            if (BasketComboBox.SelectedItem == null)
            {
                ShowError("Please select an Basket");
                return false;
            }

            if (ProductComboBox.SelectedItem == null)
            {
                ShowError("Please select a Product");
                return false;
            }

            if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                ShowError("Please enter quantity");
                return false;
            }

            if (!byte.TryParse(QuantityTextBox.Text, out quantity) || quantity < 1)
            {
                ShowError("The number must be a positive integer between 1 and 100.");
                return false;
            }

            if (quantity > 100)
            {
                ShowError("Quantity cannot exceed 100");
                return false;
            }

            ErrorMessageText.Text = string.Empty;
            return true;
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        private void ShowError(string message)
        {
            ErrorMessageText.Text = message;
            ErrorMessageText.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// 重置表单状态
        /// </summary>
        private void ResetForm()
        {
            BasketComboBox.SelectedIndex = -1;
            ProductComboBox.SelectedIndex = -1;
            QuantityTextBox.Text = "1";
            ErrorMessageText.Text = string.Empty;
            ErrorMessageText.Visibility = Visibility.Collapsed;
        }
    }
}

