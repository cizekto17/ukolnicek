using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ukolnicek.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ukolnicek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UkolnicekCreatePage : ContentPage
    {
        public UkolnicekCreatePage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Models.Ukol)BindingContext;

            note.New_Date = DateTime.Now;
            note.Original_Date = DateTime.Now;
            await App.Database.SaveNoteAsync(note);
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