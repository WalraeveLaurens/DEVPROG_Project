using DEVPROG_Project.Repositories;
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
    public partial class CharacterDetailPage : ContentPage
    {
        public Character Details { get; set; }
        public CharacterDetailPage(Character list)
        {
            InitializeComponent();
            Details = list;
            ShowSelectedCharacter();
        }

        private void ShowSelectedCharacter()
        {
            //imgChar.Source = Details.ImageUrl;
            imgChar.Source = "https://static.wikia.nocookie.net/gameofthrones/images/9/9f/Profile-Littlefinger.png/revision/latest?cb=20170826005231";


            lblFullNameTop.Text = Details.FullName;
            lblFamily.Text = "Family: " + Details.Family;
            lblFirstName.Text = "First Name: " + Details.FirstName;
            lblFullName.Text = "Full Name: " + Details.FullName;
            lblLastName.Text = "Last Name: " + Details.LastName;
            lblTitle.Text = "Title: " + Details.Title;
        }

        private void imgBackBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}