﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;


namespace Windows_Dining
{

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the Dining Data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void RestaurantListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedName = App.ViewModel.Items.ElementAt(RestaurantListBox.SelectedIndex).LineOne;
            NavigationService.Navigate(new Uri("/DiningDetail.xaml?name=" + selectedName, UriKind.Relative));
        }

        private void GoToMap_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapDetail.xaml", UriKind.Relative));
        }

        

        
    }
}