using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTest
{
    // 1. Classes: 
    // - fields, 
    // - properties, 
    // - constructors, 
    // - methods, 
    // - access modifiers(public, protected, private) 
    // - decorators such as sealed, static, virtual, abstract, override, new,

    // 1. List: 
    // - instantiation, 
    // - adding and
    // - removing items,
    // - iterating, 
    // - checking if an item is present
    internal class Weekday
    {
        // - fields
        int countNumber;

        // - properties
        public List<string> weekDay { get; set; }
        public Weekday() { 
          weekDay = new List<string>();
        }
    }
}
