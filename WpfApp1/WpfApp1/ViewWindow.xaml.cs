﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        private ViewWindowviewModel vw = new ViewWindowviewModel();

        public ViewWindow()
        {
            InitializeComponent();
            DataContext = vw;
        }
    }

    public class ViewWindowviewModel : ObservableObject
    {
        //private string viewWindowtext = "test";
        //public string ViewWindowtext { get => viewWindowtext; set => Set(ref viewWindowtext, value); }
    }
}
