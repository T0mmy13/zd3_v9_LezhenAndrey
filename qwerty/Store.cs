using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwerty
{
    public class Store
    {
        public int SalesCount { get; set; } 
        public decimal Revenue { get; set; } 
        public Store()
        {

        }
        public Store(int salesCount, decimal revenue)
        {
            SalesCount = salesCount;
            Revenue = revenue;
        }
        public decimal CalculateQuality()
        {
            return Math.Round(Revenue / SalesCount);
        }
        public override string ToString()
        {
            return $"Количество продаж: {SalesCount}, Выручка: {Revenue}, Qp: {CalculateQuality()}";
        }
        public void AddSales(int count)
        {
            SalesCount += count;
        }
        public void RemoveSales(int count)
        {
            if (SalesCount >= count)
                SalesCount -= count;
            else
                SalesCount = 0;
        }
        public void UpdateRevenue(decimal amount)
        {
            Revenue += amount;
        }
        public virtual bool CheckValues(string text1, string text2)
        {
            int a = 0;
            decimal b = 0;
            if (int.TryParse(text1, out a))
            {
                if (decimal.TryParse(text2, out b))
                {
                   return true;
                }
                else
                {
                    MessageBox.Show("Неверный ввод выручки за месяц");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Неверный ввод количества продаж");
                return false;
            }
        }
    }
}
