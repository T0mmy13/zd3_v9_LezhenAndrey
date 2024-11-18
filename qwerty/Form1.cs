using System;
using System.Collections;
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

        public int i = 1;
        ExtendedStore extendedStore = new ExtendedStore();
        private List<ExtendedStore> extendedStores = new List<ExtendedStore>();

        private void AddExtendedStoreButton_Click_1(object sender, EventArgs e)
        {
            if (extendedStore.CheckValues(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
            {
                ExtendedStore extendedStore = new ExtendedStore(
                    int.Parse(textBox1.Text),
                    decimal.Parse(textBox2.Text),
                    textBox3.Text,
                    int.Parse(textBox4.Text),
                    textBox5.Text,
                    textBox6.Text,
                    i
                );
                extendedStores.Add(extendedStore);
                MessageBox.Show(extendedStore.GetStoreSummary());
                i++;
                listBox1.Items.Clear();
                foreach (ExtendedStore store in extendedStores)
                {
                    listBox1.Items.Add($"{store.StoreName} {store.StoreID}");
                }
            }
            else
            {
                MessageBox.Show("Неверный ввод");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ExtendedStore RemoveStore = new ExtendedStore();
                int index = int.Parse(listBox1.SelectedItems[listBox1.SelectedIndex].ToString().Split(' ')[1]);
                foreach (ExtendedStore store in extendedStores)
                {
                    if(store.StoreID == index)
                    {
                        RemoveStore = store;
                    }
                }
                extendedStores = RemoveStore.DellExtendedStore(extendedStores, RemoveStore);
                listBox1.Items.Clear();
                foreach (ExtendedStore extendedStore in extendedStores)
                {
                    listBox1.Items.Add($"{extendedStore.StoreName} {extendedStore.StoreID}");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            extendedStore.RussianRoulette(this);
        }
    }
}
