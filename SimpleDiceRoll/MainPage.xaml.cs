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
        List<int> results;
        Die die = new Die();

        public MainPage()
        {
            InitializeComponent();

            //binding by code

            //source object (1) and could be loaded from service call or a database call
            die = new Die
            {
                Sides = 6,
                Rolls = 3
            };

            //gives the named Grid in the Xaml parent to the Entries a binding context
            this.BindingContext = die;

/*            Binding dieSidesBinding = new Binding();
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
            results = new List<int>();
            Random random = new Random();
            for (var i = 1; i <= die.Rolls; i++)
            {
                int randomInt = random.Next(1, die.Sides+1);
                results.Add(randomInt);
            }

            RollsResults.Text = "Resulting rolls: " + string.Join(",", results.ToArray());
        }
    }
}
