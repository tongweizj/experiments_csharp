using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_medal
{
    enum MedalColor {Bronze, Silver, Gold }
    internal class Medal
    {
        // data
        public string Name { get;  }
        public string TheEvent { get;  }
        public MedalColor Color { get;  }
        public int Year { get;  }
        public bool IsRecord { get;  }

        // constractor
        public  Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }

        public override string ToString()
        {
            return $"{Year} - {TheEvent}{(IsRecord?"(R)":"")} {Name}({Color})";
        }
    }
}
