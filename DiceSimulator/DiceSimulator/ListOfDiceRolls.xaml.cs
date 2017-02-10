using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Xamarin.Forms;

namespace DiceSimulator
{
    public partial class ListOfDiceRolls : ContentPage
    {
        DiceRollManager dcm = DiceRollManager.GetInstance();
        public ListOfDiceRolls()
        {
            InitializeComponent();
            PopulateListView(dcm.DiceRolls);
        }

        public void PopulateListView(ICollection<DiceRoll> c)
        {
            ListViewOfDiceRolls.ItemsSource = c;

            ListViewOfDiceRolls.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                //Do something
                DisplayAlert("Selected option", 
                    "Time: "+((DiceRoll)ListViewOfDiceRolls.SelectedItem).TimeRollWasPerformed 
                    + "\n Number"+ ((DiceRoll)ListViewOfDiceRolls.SelectedItem).NumberRolled, "OK");
                int index = c.ToList().IndexOf((DiceRoll)ListViewOfDiceRolls.SelectedItem);
            };
        }
    }
}
