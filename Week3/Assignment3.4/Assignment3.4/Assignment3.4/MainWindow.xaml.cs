﻿using Assignment3._4.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CoffeeViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new CoffeeViewModel();
            DataContext = _viewModel;
        }
    }
}