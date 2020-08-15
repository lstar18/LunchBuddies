using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var buddy = new LunchBuddy("Liza", "Star");
            var buddy1 = new LunchBuddy("Lori", "Star");
            var buddy2 = new LunchBuddy("Julie", "Quittner");
            var buddy3 = new LunchBuddy("Stacey", "Quittner");

            var companions = new List<LunchBuddy>();
            companions.Add(buddy1);
            companions.Add(buddy2);
            companions.Add(buddy3);

            var rest = new Restaurant();
            buddy.Eat(rest);

            buddy.Eat(rest, "a cheese plate");

            buddy.Eat(companions);

            buddy.Eat("pie", companions);
         }
    }
}
