using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entities;

namespace DiceSimulator
{
    class DiceRollManager
    {
        private static DiceRollManager instance;

        public static DiceRollManager GetInstance()
        {
            return instance ?? (instance = new DiceRollManager());
        }

        public DiceRollManager()
        {
            DiceRolls = new List<DiceRollCollection>();
        }

        public List<DiceRollCollection> DiceRolls { get; set; }

        public DiceRollCollection AddDiceRolls(DiceRollCollection diceRolls)
        {
            DiceRolls.Add(diceRolls);
            return diceRolls;
        }

        public bool RemoveDiceRollArray(DiceRollCollection diceRolls)
        {
            DiceRolls.Remove(diceRolls);
            return true;
        }

        public List<DiceRollCollection> GetListBasedOnAmountOfDicesRolled(int amountOfDices)
        {
            return DiceRolls.Where(dc => dc.DiceRolls.Count == amountOfDices).ToList();
        }

        public List<DiceRollCollection> GetListBasedOnTimeStamp(DateTime start, DateTime end)
        {
            return DiceRolls.Where(dc => 
            dc.TimeRollWasPerformed < end
            && dc.TimeRollWasPerformed > start
            ).ToList();
        }

        public DiceRollCollection PerformRolls(int amountOfRolls)
        {
            DiceRollCollection toReturn = new DiceRollCollection();
            Random rnd = new Random();
            for (int i = 0; i < amountOfRolls; i++)
            {
                DiceRoll diceRoll = new DiceRoll();
                int rndNumber = rnd.Next(0, Dice.Sides.Length - 1);
                diceRoll.NumberRolled = Dice.Sides[rndNumber];
                toReturn.DiceRolls.Add(diceRoll);
                toReturn.RollsHorisontallyAsString += diceRoll.NumberRolled + " ,";
            }
            DiceRolls.Add(toReturn);
            toReturn.TimeRollWasPerformed = DateTime.Now;
            return toReturn;
        }
    }
}
