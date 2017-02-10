using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Xamarin.Forms;

namespace DiceSimulator
{
    public partial class DiceRollPage : ContentPage
    {
        private DiceRollManager dcm = DiceRollManager.GetInstance();
        public DiceRollPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            btn_RollAndSeeList.Clicked += async (s, e) =>
            {
                if (HasValidInput())
                {
                    int amountOfRolls = Convert.ToInt32(AmountOfDices.Text);
                    for (int i = 0; i < amountOfRolls; i++)
                    {
                        DiceRoll dc = dcm.PerformRoll();
                        dcm.AddDiceRoll(dc);
                    }

                    await Navigation.PushAsync(new ListOfDiceRolls());
                }
                else
                {
                    App.MyToast.DisplayToast("ERROR - please write an amount higher than 0");
                }
            };

            btn_SeeListOfRolls.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new ListOfDiceRolls());
            };

        }

        private bool HasValidInput()
        {
            if (AmountOfDices == null)
                return false;

            if (AmountOfDices.Text.Length <= 0)
                return false;

            return true;
        }
    }
}
