using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    
    class MoneyBox : IEnumerable
    {
        public List<Money> Money { get; set; }
        public static double kpst = 250;// 5x5(taban) ,10(yükseklik) boyutlarında cm3 biriminde
        public List<Money> Break(List<Money> money)
        {
            Money = money;
            return Money;
        }

        public IEnumerator GetEnumerator()
        {
            return Money.GetEnumerator();
        }
    }
}
