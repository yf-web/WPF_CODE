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

namespace P8_1
{
    /// <summary>
    /// 路由事件
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.gridRoot.AddHandler(Button.ClickEvent,new RoutedEventHandler(this.ButtonClicked));
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"处理者：{(sender as FrameworkElement).Name}，发送者：{(e.OriginalSource as FrameworkElement).Name}");
        }
    }
}
