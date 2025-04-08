using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class NamedContainer<T>(T item, string description)
    {
        // 在申明 class 时，<T> 说明用 泛型， T item，占位符
        public T Item { get; } = item;
        public string Description { get; } = description;
        public static int Count;
        public override string ToString()
        {
            return $"{Item}, {Description}";
        }
    }
}
