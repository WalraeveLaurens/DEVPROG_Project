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
            lblFullNameTop.Text = Details.FullName;
            lblFamily.Text = Details.Family;
            lblFirstName.Text = Details.FirstName;
            lblFullName.Text = Details.FullName;
            lblLastName.Text = Details.LastName;
            lblTitle.Text = Details.Title;
        }

        private void imgBackBtn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterListPage());
        }
    }
}