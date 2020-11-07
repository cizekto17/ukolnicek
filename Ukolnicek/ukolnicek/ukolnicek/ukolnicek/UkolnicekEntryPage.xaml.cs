
using System;
using System.IO;
using Xamarin.Forms;
using ukolnicek.Models;

namespace ukolnicek
{
    public partial class UkolnicekEntryPage : ContentPage
    {
        public UkolnicekEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var ukol = (Models.Ukol)BindingContext;

            ukol.New_Date = DateTime.Now;
            await App.Database.SaveNoteAsync(ukol);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Models.Ukol)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}