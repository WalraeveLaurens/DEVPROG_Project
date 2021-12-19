using DEVPROG_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DEVPROG_Project.Repositories;
using DEVPROG_Project.Views;

namespace DEVPROG_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //TestRepositories();
            //Navigation.PushAsync(new CharacterListPage());
        }

        //private async void TestRepositories()
        //{
        //    debug.writeline("test models");
        //    //haal alle boards op en toon de naam
        //    list<character> characters = await thronesrepository.getcharacters();
        //    foreach (var item in characters)
        //    {
        //        debug.writeline(item.fullname);
        //    }



        //}

        private void btnShowList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterListPage());
        }

        private void btwShowFamily_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FamilyList());
        }


        private async void btnShowRndm_Clicked(object sender, EventArgs e)
        {            
            List<Character> characters = await ThronesRepository.GetCharacters();

            Random rnd = new Random();
            Character character = characters[rnd.Next(characters.Count)];



            
            await Navigation.PushAsync(new CharacterDetailPage(character));

        }

        private void btnAddChar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCharacterPage());
        }

        
    }
}
