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

namespace demo_wpf
{
    

    /// <summary>
    /// CounterUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class CounterUserControl : UserControl
    {
        private int _count = 0; // 计数器私有变量

        public CounterUserControl()
        {
            InitializeComponent();
            UpdateCountText(); // 初始化显示
        }

        // 计数器值属性 (DependencyProperty)
        // **1. 依赖属性包装器 (Property Wrapper):  CLR 属性，用于外部访问和数据绑定**
        //    -  这是 UserControl 对外公开的属性 (类似于普通的 C# 属性)
        //    -  使用 get 和 set 访问器，但内部调用 GetValue 和 SetValue 来操作依赖属性系统

        public int Count
        {
            get { return (int)GetValue(CountProperty); } // 从依赖属性系统中获取值
            set { SetValue(CountProperty, value); }
        }

        // 依赖属性注册 (DependencyProperty.Register) 静态只读字段，标识和注册依赖属性**
        //    -  必须是 public static readonly 字段
        //    -  字段类型必须是 DependencyProperty
        //    -  使用 DependencyProperty.Register 方法进行注册
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(CounterUserControl), new PropertyMetadata(0, OnCountPropertyChanged));

        // Count 属性值改变时的回调函数
        // **3. 属性更改回调函数 (Property Changed Callback):  静态方法，当 Count 属性值改变时自动调用**
        //    -  必须是 static 方法
        //    -  签名必须是 (DependencyObject d, DependencyPropertyChangedEventArgs e)

        private static void OnCountPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //  d:  属性值发生改变的 DependencyObject 对象，这里是 CounterUserControl 实例
            //  e:  事件参数，包含旧值 (e.OldValue) 和新值 (e.NewValue)
            CounterUserControl control = d as CounterUserControl;
            if (control != null)
            {
                control.UpdateCountText(); // 更新 TextBlock 显示
                //  可以在这里添加其他属性值改变时的逻辑，例如触发事件，执行其他操作等
            }
        }

        // 更新 TextBlock 显示计数
        private void UpdateCountText()
        {
            txtCount.Text = Count.ToString();
        }


        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            Count++; // 增加 Count 属性值，会触发 PropertyChangedCallback
        }

        private void btnDecrease_Click(object sender, RoutedEventArgs e)
        {
            Count--; // 减少 Count 属性值，会触发 PropertyChangedCallback
        }
    }
}
