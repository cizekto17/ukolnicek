using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using ukolnicek.Models;

namespace ukolnicek
{
    public partial class UkolnicekMainPage : ContentPage
    {
        public UkolnicekMainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void AddUkol(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UkolnicekCreatePage
            {
                BindingContext = new Models.Ukol()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new UkolnicekEntryPage
                {
                    BindingContext = e.SelectedItem as Models.Ukol
                });

            }
        }
    }
}