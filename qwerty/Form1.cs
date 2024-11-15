using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwerty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Store store = new Store();
        ExtendedStore extendedStore = new ExtendedStore();
        private List<Store> stores = new List<Store>(); 
        private List<ExtendedStore> extendedStores = new List<ExtendedStore>(); 
        private void AddStoreButton_Click_1(object sender, EventArgs e)
        {
            if (store.CheckValues(textBox1.Text, textBox2.Text))
            {
                Store store = new Store(int.Parse(textBox1.Text), decimal.Parse(textBox2.Text));
                stores.Add(store);
                MessageBox.Show(store.ToString());
            }                   
        }
        private void AddExtendedStoreButton_Click_1(object sender, EventArgs e)
        {
            if (extendedStore.CheckValues(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                ExtendedStore extendedStore = new ExtendedStore(int.Parse(textBox1.Text), decimal.Parse(textBox2.Text), int.Parse(textBox3.Text));
                extendedStores.Add(extendedStore);
                MessageBox.Show(extendedStore.GetStoreSummary());
            }                     
        }
    }
}
