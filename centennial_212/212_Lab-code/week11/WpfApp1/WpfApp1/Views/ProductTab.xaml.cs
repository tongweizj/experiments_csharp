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
    /// Interaction logic for ProductTab.xaml
    /// </summary>
    public partial class ProductTab : UserControl
    {


        // 模拟数据
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public ProductTab()
        {
            InitializeComponent();
            //LoadSampleData();
            //DataContext = this;
        }
        private void LoadSampleData()
        {
            // 加载示例订单数据
            Orders = new List<Order>
            {
                new Order { Id = 1, OrderNumber = "ORD-2023-001" },
                new Order { Id = 2, OrderNumber = "ORD-2023-002" },
                new Order { Id = 3, OrderNumber = "ORD-2023-003" }
            };

            // 加载示例商品数据
            Products = new List<Product>
            {
                new Product { Id = 1, ProductName = "笔记本电脑", Price = 5999.99m },
                new Product { Id = 2, ProductName = "智能手机", Price = 3999.99m },
                new Product { Id = 3, ProductName = "无线耳机", Price = 499.99m },
                new Product { Id = 4, ProductName = "智能手表", Price = 1299.99m }
            };

            // 绑定数据到ComboBox
            OrderComboBox.ItemsSource = Orders;
            ProductComboBox.ItemsSource = Products;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // 验证输入
            if (OrderComboBox.SelectedItem == null)
            {
                ErrorMessageText.Text = "请选择一个订单";
                return;
            }

            if (ProductComboBox.SelectedItem == null)
            {
                ErrorMessageText.Text = "请选择一个商品";
                return;
            }

            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                ErrorMessageText.Text = "请输入有效的数量";
                return;
            }

            // 获取选中的订单和商品
            var selectedOrder = (Order)OrderComboBox.SelectedItem;
            var selectedProduct = (Product)ProductComboBox.SelectedItem;

            // 在实际应用中，这里会调用服务或数据库操作
            // 例如: orderService.AddProductToOrder(selectedOrder.Id, selectedProduct.Id, quantity);

            // 显示成功消息
            MessageBox.Show($"成功添加 {quantity} 个 {selectedProduct.ProductName} 到订单 {selectedOrder.OrderNumber}",
                            "操作成功",
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
            OrderComboBox.SelectedIndex = -1;
            ProductComboBox.SelectedIndex = -1;
            QuantityTextBox.Text = "1";
            ErrorMessageText.Text = string.Empty;
        }
    }
}


// 订单模型
public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
}

// 商品模型
public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }


}
