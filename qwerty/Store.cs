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
        public int SalesCount;
        public decimal Revenue;
        public string StoreName;
        public Store()
        {

        }
        public Store(int salesCount, decimal revenue, string storeName)
        {
            SalesCount = salesCount;
            Revenue = revenue;
            StoreName = storeName;
        }
        public Store[] AddStore(Store[] stores, Store newStore)
        {
            var freeSlotIndex = Array.FindIndex(stores, store => store == null);
            if (freeSlotIndex != -1)
            {
                stores[freeSlotIndex] = newStore;                
            }
            else
            {
                MessageBox.Show("Нет свободного места");
            }
            return stores;
        }
        public static Store[] RemoveStore(Store[] stores, Store storeToRemove)
        {
            return stores.Where(store => !store.Equals(storeToRemove)).ToArray();
        }
        public static Store[] RemoveStore(Store[] stores, string storeNameToRemove)
        {
            return stores.Where(store => store.StoreName != storeNameToRemove).ToArray();
        }
        public decimal CalculateQuality()
        {
            return Math.Round(Revenue / SalesCount);
        }
        public override string ToString()
        {
            return $"Магазин: {StoreName}\nКоличество продаж: {SalesCount}\nВыручка: {Revenue}\nQ: {CalculateQuality()}";
        }        
        public virtual bool CheckValues(string text1, string text2, string text3)
        {
            int a = 0;
            decimal b = 0;
            if (int.TryParse(text1, out a))
            {
                if (decimal.TryParse(text2, out b))
                {
                    if (!string.IsNullOrEmpty(text3))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {                    
                    return false;
                }
            }
            else
            {                
                return false;
            }
        }
    }
}
