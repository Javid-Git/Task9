using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    class Milk : Product
    {
        public double Volume;
        public double FatRate;

        public Milk(string name) : base(name)
        {

        }

        public void Sell(int a)
        {
            if(Count > a)
            {
                TotalIncome = a * Price;
                Count -= a;
                Console.WriteLine($"Sizin satisdan umumi geliriniz {TotalIncome} AZN teskil edir");
            }
            else
            {
                Console.WriteLine($"Satila bilmez! Ancaq {Count} eded var");
            }return;
        }
    }


}
