using ManageOradersSystem.Models;
using ManageOradersSystem.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
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
using MenuItem = ManageOradersSystem.Models.Menu;

namespace ManageOradersSystem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private BasketsViewModel _basketsViewModel;
    private MenusViewModel _viewModel;

    public MainWindow()
    {
        InitializeComponent();
        _viewModel = new MenusViewModel();
        _basketsViewModel = new BasketsViewModel();
        
        DataContext = _viewModel;
        DataContext = _basketsViewModel;

        BindComboBoxes();
    }

    private void BindComboBoxes()
    {
        // NEW ADD
        var basketList = _basketsViewModel.baskets.ToList();
        BasketComboBox.ItemsSource = basketList;
        BasketComboBox.DisplayMemberPath = "IdBasket";
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
            _basketsViewModel.SelectedBasket = selectedBasket;

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
            //AddToBill(selectedItem);
        }
    }



    private void Button_Click(object sender, RoutedEventArgs e)
    {
        
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
    
    }

}