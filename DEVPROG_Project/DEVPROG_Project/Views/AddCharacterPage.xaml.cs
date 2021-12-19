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

            
            string desc = "First name: " + FirstName.Text + "\n" +
                "Last Name: " + LastName.Text + "\n" +
                "Full Name: " + FirstName.Text + " " + LastName.Text + "\n" +
                "Title: " + Title.Text + "\n" +
                "Family: " + Family.Text + "\n" +
                "ImageUrl: " + ImageUrl.Text;  
                
            CharacaterCard characaterCard = new CharacaterCard() { Name= FirstName.Text ,Description = desc };

            await ThronesRepository.AddCardAsync(characaterCard);

            


            Character info = new Character() { FirstName = FirstName.Text, LastName = LastName.Text, FullName = FirstName.Text + " " + LastName.Text, Family = Family.Text, ImageUrl = ImageUrl.Text, Title = Title.Text };
            await Navigation.PushAsync(new CharacterDetailPage(info));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}