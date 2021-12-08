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

namespace DEVPROG_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestRepositories();
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
    }
}
