﻿using AnimeDesktop.ViewModel;
using System.Windows.Controls;

namespace AnimeDesktop.View
{
    public partial class TopHundredView : UserControl
    {
        public TopHundredView()
        {
            InitializeComponent();
            var topHundredViewModel = new TopHundredViewModel();

            DataContext = topHundredViewModel;
        }
    }
}