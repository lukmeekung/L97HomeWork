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

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NewDataAss.InitializeDatabase();
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NewDataAss.AddData(nameTxt.Text);
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach(string data in NewDataAss.GetData())
            {
                MessageBox.Show(data);
            }
        }
    }
}
