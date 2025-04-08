using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    List<MenuItem> menuItems;
    List<string> selectedBills;
    public ObservableCollection<BillItem> billItems { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        LoadMenuItems();
        BindComboBoxes();
        billItems = new ObservableCollection<BillItem>();
        selectedBills = new List<string>();
        billItemsDataGrid.DataContext = billItems;

    }
    public void LoadMenuItems()
    {
        menuItems = new List<MenuItem>
{
    // Beverages
    new MenuItem { Category = "Beverage", Name = "Coca-Cola", Price = 2.50m },
    new MenuItem { Category = "Beverage", Name = "Orange Juice", Price = 3.00m },
    new MenuItem { Category = "Beverage", Name = "Lemonade", Price = 3.50m },
    new MenuItem { Category = "Beverage", Name = "Iced Coffee", Price = 4.00m },
    new MenuItem { Category = "Beverage", Name = "Green Tea", Price = 2.80m },
    new MenuItem { Category = "Beverage", Name = "Milkshake", Price = 5.00m },
    new MenuItem { Category = "Beverage", Name = "Espresso", Price = 2.75m },
    new MenuItem { Category = "Beverage", Name = "Hot Chocolate", Price = 3.75m },
    new MenuItem { Category = "Beverage", Name = "Mineral Water", Price = 2.00m },
    new MenuItem { Category = "Beverage", Name = "Fruit Smoothie", Price = 4.50m },

    // Appetizers
    new MenuItem { Category = "Appetizer", Name = "Caesar Salad", Price = 6.50m },
    new MenuItem { Category = "Appetizer", Name = "Bruschetta", Price = 7.00m },
    new MenuItem { Category = "Appetizer", Name = "Mozzarella Sticks", Price = 6.75m },
    new MenuItem { Category = "Appetizer", Name = "Spring Rolls", Price = 5.50m },
    new MenuItem { Category = "Appetizer", Name = "Buffalo Wings", Price = 8.00m },
    new MenuItem { Category = "Appetizer", Name = "Garlic Bread", Price = 4.50m },
    new MenuItem { Category = "Appetizer", Name = "Stuffed Mushrooms", Price = 6.80m },
    new MenuItem { Category = "Appetizer", Name = "French Fries", Price = 4.00m },
    new MenuItem { Category = "Appetizer", Name = "Onion Rings", Price = 4.50m },
    new MenuItem { Category = "Appetizer", Name = "Cheese Platter", Price = 9.00m },

    // Main Course
    new MenuItem { Category = "Main Course", Name = "Grilled Ribeye Steak", Price = 22.00m },
    new MenuItem { Category = "Main Course", Name = "Salmon Fillet", Price = 18.50m },
    new MenuItem { Category = "Main Course", Name = "Chicken Alfredo Pasta", Price = 14.75m },
    new MenuItem { Category = "Main Course", Name = "BBQ Ribs", Price = 19.99m },
    new MenuItem { Category = "Main Course", Name = "Vegetable Stir-Fry", Price = 12.50m },
    new MenuItem { Category = "Main Course", Name = "Beef Tacos", Price = 11.00m },
    new MenuItem { Category = "Main Course", Name = "Lobster Tail", Price = 25.00m },
    new MenuItem { Category = "Main Course", Name = "Mushroom Risotto", Price = 15.20m },
    new MenuItem { Category = "Main Course", Name = "Margherita Pizza", Price = 13.50m },
    new MenuItem { Category = "Main Course", Name = "Teriyaki Chicken", Price = 14.00m },

    // Desserts
    new MenuItem { Category = "Dessert", Name = "Chocolate Lava Cake", Price = 8.00m },
    new MenuItem { Category = "Dessert", Name = "Tiramisu", Price = 7.50m },
    new MenuItem { Category = "Dessert", Name = "Cheesecake", Price = 6.80m },
    new MenuItem { Category = "Dessert", Name = "Apple Pie", Price = 5.50m },
    new MenuItem { Category = "Dessert", Name = "Crème Brûlée", Price = 9.00m },
    new MenuItem { Category = "Dessert", Name = "Ice Cream Sundae", Price = 6.00m },
    new MenuItem { Category = "Dessert", Name = "Pavlova", Price = 7.20m },
    new MenuItem { Category = "Dessert", Name = "Churros", Price = 5.80m },
    new MenuItem { Category = "Dessert", Name = "Fruit Tart", Price = 6.90m },
    new MenuItem { Category = "Dessert", Name = "Brownie with Ice Cream", Price = 7.00m }
};

    }
    private void BindComboBoxes()
    {
        var beverages = menuItems.Where(item => item.Category == "Beverage").ToList();
        var appetizers = menuItems.Where(item => item.Category == "Appetizer").ToList();
        var mainCourses = menuItems.Where(item => item.Category == "Main Course").ToList();
        var desserts = menuItems.Where(item => item.Category == "Dessert").ToList();

        // Bind to ComboBox (assuming you have WPF ComboBoxes named BeverageComboBox, etc.)
        BeverageComboBox.ItemsSource = beverages;
        BeverageComboBox.DisplayMemberPath = "Name";
        BeverageComboBox.SelectedValuePath = "Price";

        AppetizerComboBox.ItemsSource = appetizers;
        AppetizerComboBox.DisplayMemberPath = "Name";
        AppetizerComboBox.SelectedValuePath = "Price";

        MainCoursesComboBox.ItemsSource = mainCourses;
        MainCoursesComboBox.DisplayMemberPath = "Name";
        MainCoursesComboBox.SelectedValuePath = "Price";

        DessertsComboBox.ItemsSource = desserts;
        DessertsComboBox.DisplayMemberPath = "Name";
        DessertsComboBox.SelectedValuePath = "Price";
    }

    public void AddToBill(MenuItem selectedItem)
    {
        if (selectedItem == null) return;

        // Check if item is already in the bill
        var existingItem = billItems.FirstOrDefault(item => item.Name == selectedItem.Name);

        if (existingItem != null)
        {
            existingItem.Quantity++;  // Increase quantity
        }
        else
        {
            billItems.Add(new BillItem
            {
                Name = selectedItem.Name,
                Price = selectedItem.Price,
                Quantity = 1
            });
        }

        UpdateBill();
    }

    public void UpdateBill()
    {
        decimal subtotal = billItems.Sum(item => item.Subtotal);
        decimal tax = subtotal * 0.10m;
        decimal total = subtotal + tax;

        SubTotalLabel.Text = $"{subtotal:F2}";
        TaxLabel.Text = $"{tax:F2}";
        TotalLabel.Text = $"{total:F2}";
    }

    public void RemoveFromBill(string itemName)
    {
        var itemToRemove = billItems.FirstOrDefault(item => item.Name == itemName);
        if (itemToRemove != null)
        {
            billItems.Remove(itemToRemove);
            UpdateBill();
        }
    }

    public void ClearBill()
    {
        billItems.Clear();
        UpdateBill();
    }

    private void BeverageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // 获取选中的项
        ComboBox comboBox = sender as ComboBox;
        MenuItem selectedItem = comboBox.SelectedItem as MenuItem;

        // 在这里执行您的方法
        if (selectedItem != null)
        {
            // 在这里执行您的方法
            AddToBill(selectedItem);
        }

    }

    private void AppetizerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // 获取选中的项
        ComboBox comboBox = sender as ComboBox;
        MenuItem selectedItem = comboBox.SelectedItem as MenuItem;

        // 在这里执行您的方法
        if (selectedItem != null)
        {
            // 在这里执行您的方法
            AddToBill(selectedItem);
        }
    }

    private void MainCoursesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // 获取选中的项
        ComboBox comboBox = sender as ComboBox;
        MenuItem selectedItem = comboBox.SelectedItem as MenuItem;

        // 在这里执行您的方法
        if (selectedItem != null)
        {
            // 在这里执行您的方法
            AddToBill(selectedItem);
        }
    }

    private void DessertsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // 获取选中的项
        ComboBox comboBox = sender as ComboBox;
        MenuItem selectedItem = comboBox.SelectedItem as MenuItem;

        // 在这里执行您的方法
        if (selectedItem != null)
        {
            // 在这里执行您的方法
            AddToBill(selectedItem);
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        //ClearBill();
        selectedBills.Clear();


        foreach (BillItem item in billItems)
        {
            if (item.IsSelected)
            {
                selectedBills.Add(item.Name);

            }

        }
        foreach (string item in selectedBills)
        {
            RemoveFromBill(item);
        }
        UpdateBill();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        ClearBill();
    }

    private void billItemsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Console.WriteLine("we are here");
        UpdateBill();
    }

    private void billItemsDataGrid_CurrentCellChanged(object sender, EventArgs e)
    {
        UpdateBill();
    }

    private void billItemsDataGrid_CellEditEnding(object sender, EventArgs e)

    {
        UpdateBill();
    }
}
