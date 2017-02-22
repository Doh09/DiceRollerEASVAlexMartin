using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DiceRollCollection
    {
        public List<DiceRoll> DiceRolls { get; set; } = new List<DiceRoll>();
        public DateTime TimeRollWasPerformed { get; set; }
        public string imgPath { get; set; }
        public string RollsHorisontallyAsString { get; set; } = "Numbers rolled: ";
    }
}
