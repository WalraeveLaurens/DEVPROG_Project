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
    public partial class CharacterListPage : ContentPage
    {
        public CharacterListPage()
        {
            InitializeComponent();
            ShowCharacters();

        }

        private async void ShowCharacters()
        {
            List<Character> characters = await ThronesRepository.GetCharacters();
            lvwCharacterList.ItemsSource = characters;
        }

        private void lvwCharacterList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwCharacterList.SelectedItem != null)
            {
                Character info = (Character)lvwCharacterList.SelectedItem;
                Navigation.PushAsync(new CharacterDetailPage(info));
                lvwCharacterList.SelectedItem = null;
            }
        }
    }
}