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

/*            //binding by code

            //source object (1) and could be loaded from  serivce
            Die die = new Die
            {
                Sides = 6,
                Rolls = 3
            };

            Binding dieSidesBinding = new Binding();
            dieSidesBinding.Source = die;
            dieSidesBinding.Path = "Sides";  //source object property (2)
            SidesEntry.SetBinding(Entry.TextProperty, dieSidesBinding);  //target is specified by name SidesEntry (3) and the property is the Entry's TextProperty (4)

            //second binding to the same source object but different property, target and target property
            Binding dieRollsBinding = new Binding();
            dieRollsBinding.Source = die;
            dieRollsBinding.Path = "Rolls";
            RollsEntry.SetBinding(Entry.TextProperty, dieRollsBinding);*/

            //TODO:  NEED METHOD FOR CREATING ROLL RESULTS AND BIND TO VIEW THE RESULTS OF ROLLS
            //DisplayAlert("Binding Set", "Die sides = " + die.Sides + ", Num of rolls = " + die.Rolls, "OK");
        }

        public void RollDiceButton(object sender, EventArgs e)
        {            
            Random rnd = new Random();
        }
    }
}
