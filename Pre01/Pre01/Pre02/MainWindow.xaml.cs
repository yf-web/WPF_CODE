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

namespace Pre02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.b1.Click += B1_Click;
            //this.b1.Click -= B1_Click;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你好 button clicked!");
        }
    }
}
