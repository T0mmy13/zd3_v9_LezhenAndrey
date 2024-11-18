using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwerty
{
    public class ExtendedStore : Store
    {
        public string Country { get; set; }
        public string Location { get; set; }
        public int StoreID { get; set; }
        public int P;
        public ExtendedStore()
        {
            
        }
        public ExtendedStore(int salesCount, decimal revenue, string storeName, int customersCount, string country, string location, int storeId) : base(salesCount, revenue, storeName)
        {
            P = customersCount;
            Country = country;
            Location = location;
            StoreID = storeId;
        }
        public void RussianRoulette(Form1 form)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            MessageBox.Show("Сгенерированное число: " + randomNumber);

            if (randomNumber == 7)
            {
                form.Close();
            }
        }
        public List<ExtendedStore> AddExtendedStore(ExtendedStore store, List<ExtendedStore> stores)
        {
            stores.Add(store);
            return stores;
        }
        public List<ExtendedStore> DellExtendedStore(List<ExtendedStore> stores, ExtendedStore storeToRemove)
        {
            if (storeToRemove == null)
            {
                MessageBox.Show("Не удалось удалить магазин. Объект магазина не найден.");
                return stores;
            }
            if (stores.Remove(storeToRemove))
            {
                MessageBox.Show($"Магазин '{storeToRemove.StoreName}' успешно удален.");
            }
            else
            {
                MessageBox.Show($"Магазин '{storeToRemove.StoreName}' не найден.");
            }

            return stores;
        }
        public decimal AverageRevenuePerCustomer => Revenue / P;
        public decimal CalculateCombinedQuality()
        {
            decimal baseQuality = CalculateQuality();
            return Math.Round(
                new[] {
                    2 * baseQuality,
                    0.5m * baseQuality
                }
                .Where((value, index) => P > 50000 ^ index == 1)
                .First());
        }
        public string GetStoreSummary()
        {
            return $"Магазин: {StoreName}\nКоличество продаж: {SalesCount}\nВыручка: {Revenue}\nклиенты {P}\nQp: {CalculateCombinedQuality()}\nСтрана: {Country}\nМестонахождение: {Location}\nID: {StoreID}";
        }
        public bool CheckValues(string text1, string text2,  string text3, string text4, string text5, string text6)
        {
            int c;
            if (base.CheckValues(text1, text2, text3) &&
                int.TryParse(text4, out c) &&
                !string.IsNullOrEmpty(text5) &&
                !string.IsNullOrEmpty(text6))
            {
                return true;
            }                      
            else
            {                
                return false;
            }
        }
    }
}
