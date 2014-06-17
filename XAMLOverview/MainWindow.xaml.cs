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

namespace XAMLOverview
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

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            btnHello.Content = "Bob";
            btnHello.Background = Brushes.BurlyWood;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "You Clicked me!";
            if (btnClicky.Content != s)
                btnClicky.Content = s;
            else
                btnClicky.Content = "Click Me!";
        }
    }
}
