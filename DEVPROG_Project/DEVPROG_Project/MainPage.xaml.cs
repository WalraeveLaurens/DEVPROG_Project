﻿using DEVPROG_Project.Models;
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
            TestRepositories();
            //Navigation.PushAsync(new CharacterListPage());
        }

        private async void TestRepositories()
        {
            Debug.WriteLine("Test Models");
            //Haal alle boards op en toon de naam
            List<Character> characters = await ThronesRepository.GetCharacters();
            foreach (var item in characters)
            {
                Debug.WriteLine(item.FullName);
            }
        }

        private void btnShowList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterListPage());
        }

        private void btwShowFamily_Clicked(object sender, EventArgs e)
        {

        }

        private void btnShowRndm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterListPage());
        }

        private void btnAddChar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterListPage());
        }
    }
}
