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

        public void PopulateListView(List<DiceRollCollection> c)
        {
            //List<ViewCell> viewCells = new List<ViewCell>();

            //ListViewOfDiceRolls = new ListView();
            //foreach (var info in c)
            //{
            //    ViewCell v = new ViewCell();
            //    StackLayout sl = new StackLayout();
            //    sl.Orientation= StackOrientation.Horizontal;
            //    foreach (var roll in info.DiceRolls)
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = roll.NumberRolled+"";
            //        sl.Children.Add(lbl);
            //    }
            //    v.View = sl;
            //    viewCells.Add(v);
            //}

            ListViewOfDiceRolls.ItemsSource = c;

            ListViewOfDiceRolls.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                //Do something
                //DisplayAlert("Selected option", 
                //    "Time: "+((DiceRollCollection)ListViewOfDiceRolls.SelectedItem).TimeRollWasPerformed 
                //    + "\n Amount of rolls: "+ ((DiceRollCollection)ListViewOfDiceRolls.SelectedItem).DiceRolls.Count, "OK");
                //int index = c.ToList().IndexOf((DiceRollCollection)ListViewOfDiceRolls.SelectedItem);
            };
        }
    }
}
