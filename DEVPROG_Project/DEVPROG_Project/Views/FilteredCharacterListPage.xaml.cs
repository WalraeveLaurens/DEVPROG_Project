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
    public partial class FilteredCharacterListPage : ContentPage
    {
        public FilteredCharacterListPage(string Family)
        {
            InitializeComponent();
            ShowFamilyList(Family);
        }

        private async void ShowFamilyList(string FamilyFilter)
        {
            List<Character> characters = await ThronesRepository.GetCharacters();

            List<Character> FilteredCharacters = new List<Character>();
            foreach (var item in characters)
            {
                if (item.Family == FamilyFilter)
                {
                    FilteredCharacters.Add(item);
                }
            }

            lvwCharacterList.ItemsSource = FilteredCharacters;
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