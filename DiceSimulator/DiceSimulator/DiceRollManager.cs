using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            DiceRolls = new List<DiceRoll>();
        }

        public List<DiceRoll> DiceRolls { get; set; }

        public DiceRoll AddDiceRoll(DiceRoll diceRoll)
        {
            DiceRolls.Add(diceRoll);
            return diceRoll;
        }

        public bool RemoveDiceRoll(DiceRoll diceRoll)
        {
            DiceRolls.Remove(diceRoll);
            return true;
        }

        public List<DiceRoll> GetListBasedOnSideRolled(int side)
        {
            return DiceRolls.Where(dc => dc.NumberRolled == side).ToList();
        }

        public List<DiceRoll> GetListBasedOnTimeStamp(DateTime start, DateTime end)
        {
            return DiceRolls.Where(dc => 
            dc.TimeRollWasPerformed < end
            && dc.TimeRollWasPerformed > start
            ).ToList();
        }

        public DiceRoll PerformRoll()
        {
            Random rnd = new Random();
            DiceRoll toReturn = new DiceRoll();
            toReturn.NumberRolled = Dice.Sides[rnd.Next(0, Dice.Sides.Length - 1)];
            toReturn.TimeRollWasPerformed = DateTime.Now;
            return toReturn;
        }
    }
}
