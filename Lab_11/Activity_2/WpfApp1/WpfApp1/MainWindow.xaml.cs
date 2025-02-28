﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                if (cb.Name == "checkBox1")
                    textBox1.Text = "2 state CheckBox is checked.";
                else
                    textBox2.Text = "3 state CheckBox is checked.";
            }
            else if (cb.IsChecked == false)
            {
                if (cb.Name == "checkBox1")
                    textBox1.Text = "2 state CheckBox is unchecked.";
                else
                    textBox2.Text = "3 state CheckBox is unchecked.";
            }
            else
            {
                if (cb.Name == "checkBox2")
                    textBox2.Text = "3 state CheckBox is in indeterminate state.";
            }
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Name == "checkBox1")
                textBox1.Text = "2 state CheckBox is unchecked.";
            else
                textBox2.Text = "3 state CheckBox is unchecked.";
        }
        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == null) // Indeterminate state
            {
                textBox2.Text = "3 state CheckBox is in indeterminate state.";
            }
        }
    }
}
