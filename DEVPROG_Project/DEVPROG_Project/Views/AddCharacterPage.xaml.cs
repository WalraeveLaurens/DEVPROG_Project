using DEVPROG_Project.Models;
using DEVPROG_Project.Repositories;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List<Character> characters = await ThronesRepository.GetCharacters();
            int i = characters.Count();
            List<Character> NewCharacter = new List<Character>();
            //id
            NewCharacter.AddRange(i++, FirstName.Text, LastName.Text, FirstName.Text +  " " + LastName.Text, Title.Text, Family.Text, "", ImageUrl.Text);


            //Character info = (Character)lvwCharacterList.SelectedItem;
            //Navigation.PushAsync(new CharacterDetailPage());

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}