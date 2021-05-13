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
        //List<Die> results = new List<Die>();
        public MainPage()
        {
            InitializeComponent();

            //binding by code or by xaml

            //source object (1) and could be loaded from  serivce

            Die die = new Die
            {
                Sides = 6,
                Rolls = 3
            };

            // binding by code in the code behind is demonstrated below

            // Entry dieSidesEntry = new Entry();  // target object (3), the entry and can be in xaml

            Binding dieSidesBinding = new Binding();
            dieSidesBinding.Source = die;
            dieSidesBinding.Path = "Sides";  // source object property (2)
            SidesEntry.SetBinding(Entry.TextProperty, dieSidesBinding);  // find UI View to Codebehind Source Object


            Binding dieRollsBinding = new Binding();
            dieRollsBinding.Source = die;
            dieRollsBinding.Path = "Rolls";
            RollsEntry.SetBinding(Entry.TextProperty, dieRollsBinding);  // find UI View to Codebehind Source Object

            // TODO:  NEED METHOD FOR CREATING ROLL RESULTS AND BIND TO VIEW THE RESULTS OF ROLLS

            DisplayAlert("Binding Set", "Die sides = " + die.Sides + ", Num of rolls = " + die.Rolls, "OK");

        }

        public void RollDiceButton(object sender, EventArgs e)
        {
            
            Random rnd = new Random();

        }

    }
}
