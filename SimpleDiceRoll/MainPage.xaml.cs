using SimpleDiceRoll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleDiceRoll
{
    public partial class MainPage : ContentPage
    {
        List<Die> results = new List<Die>();
        public MainPage()
        {
            InitializeComponent();

            // binding by code or by xaml

            // binding by code in the code behind is demonstrated below

            Die die = new Die();  // source object (1) and could be loaded from  serivce

            Entry dieSidesEntry = new Entry();  // target object (3), the entry
            
            Binding sidesBinding = new Binding();
            sidesBinding.Source = die;
            sidesBinding.Path = "Sides";  // source object property (2)
            SidesEntry.SetBinding(Entry.TextProperty, sidesBinding);  // find UI View to Codebehind Source Object


            Binding rollsBinding = new Binding();
            rollsBinding.Source = die;
            rollsBinding.Path = "Rolls";
            RollsEntry.SetBinding(Entry.TextProperty, rollsBinding);  // find UI View to Codebehind Source Object

            // TODO:  NEED METHOD FOR CREATING ROLL RESULTS AND BIND TO VIEW THE RESULTS OF ROLLS

            DisplayAlert("Binding Set", "Die sides = " + die.Sides + ", Num of rolls = " + die.Rolls, "OK");

        }

        private void RollDiceButton (int sides, int rolls)
        {
            
            Random rnd = new Random();

        }

    }
}
