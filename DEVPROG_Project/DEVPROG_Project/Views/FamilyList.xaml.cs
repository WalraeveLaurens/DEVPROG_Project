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
    public partial class FamilyList : ContentPage
    {
        public FamilyList()
        {
            InitializeComponent();
            ShowFamilies();
        }

        private async void ShowFamilies()
        {
            List<Character> characters = await ThronesRepository.GetCharacters();
            List<string> FamiliesDup = new List<string>();
            foreach (var item in characters)
            {
                FamiliesDup.Add(item.Family);
            }
            List<string> Families = FamiliesDup.Distinct().ToList();
            lvwFamilyList.ItemsSource = Families;
        }

        private void lvwFamilyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwFamilyList.SelectedItem != null)
            {
                string Family = (string)lvwFamilyList.SelectedItem;
                Navigation.PushAsync(new FilteredCharacterListPage(Family));
                lvwFamilyList.SelectedItem = null;
            }
        }
    }
}