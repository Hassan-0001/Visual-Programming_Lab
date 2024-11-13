using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _233516_Lab__6_
{
    public partial class Form1 : Form
    {
        private List<string> stringList = new List<string>();
        private ArrayList arrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            string item = Text_Box.Text;  // Assuming Text_Box is your input TextBox for adding items.
            if (!string.IsNullOrEmpty(item))
            {
                stringList.Add(item);
                arrayList.Add(item); // Add item to the ArrayList
                Text_Box.Clear(); // Clear the TextBox after adding
            }

            DisplayItems(); // Refresh the ListBox display
        }

        private void DisplayItems()
        {
            List_Box.Items.Clear(); // Clear current items in the ListBox

            foreach (var item in stringList)
            {
                List_Box.Items.Add(item); // Add each item to the ListBox
            }
        }

        private void Remove_item_Click(object sender, EventArgs e)
        {
            if (List_Box.SelectedItem != null)
            {
                string selectedItem = List_Box.SelectedItem.ToString();
                stringList.Remove(selectedItem);
                arrayList.Remove(selectedItem);
                DisplayItems();
            }
        }

        private void SortList_Click(object sender, EventArgs e)
        {
            stringList.Sort();
            DisplayItems();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            stringList.Clear();
            arrayList.Clear();
            DisplayItems();
        }
    }

}

