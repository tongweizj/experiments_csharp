using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManageOradersSystem.ViewModel
{
    // 定义 ViewModelBase 基类
    // 用于实现WPF/MVVM模式中的数据绑定通知机制
    // INotifyPropertyChanged 接口
    // WPF数据绑定的核心，用于在属性值改变时通知UI更新
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            // 这是一个受保护的虚方法，派生类可以调用或重写它
            // [CallerMemberName] 特性会自动获取调用此方法的属性名
            // 方法安全地触发PropertyChanged事件（使用?.避免空引用异常）
            // 当属性值改变时，调用此方法会通知UI更新对应绑定
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // 更安全的Set方法
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
