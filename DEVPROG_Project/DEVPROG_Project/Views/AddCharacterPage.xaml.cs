using DEVPROG_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DEVPROG_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCharacterPage : ContentPage
    {
        public AddCharacterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Character info = (Character)lvwCharacterList.SelectedItem;
            //Navigation.PushAsync(new CharacterDetailPage());
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}