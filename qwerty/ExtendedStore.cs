using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwerty
{
    public class ExtendedStore : Store
    {
        public int CustomersCount { get; set; }
        public ExtendedStore()
        {
            
        }
        public ExtendedStore(int salesCount, decimal revenue, int customersCount) : base(salesCount, revenue)
        {
            CustomersCount = customersCount;
        }
        public decimal AverageRevenuePerCustomer => Revenue / CustomersCount;
        public decimal CalculateCombinedQuality()
        {
            decimal baseQuality = CalculateQuality();
            if(CustomersCount > 50000)
            {
                return Math.Round(2 * baseQuality);
            }
            else
            {
                return Math.Round(0.5m * baseQuality);
            }
        }
        public string GetStoreSummary()
        {
            return $"Магазин: продаж {SalesCount}, выручка {Revenue}, клиенты {CustomersCount}, Qp {CalculateCombinedQuality()}";
        }
        public bool CheckValues(string text1, string text2, string text3)
        {
            if (!base.CheckValues(text1, text2))
            {
                return false;
            }
            int c = 0;
            if (int.TryParse(text3, out c))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверный ввод количества покупателей");
                return false;
            }
        }
    }
}
