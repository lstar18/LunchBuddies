using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        public void Eat(Restaurant restaurant)
        {
            ;
            Console.WriteLine($"{FirstName} ate dinner at {restaurant.Name}.");
        }
        public void Eat(Restaurant restaurant, string food)
        {
            Console.WriteLine($"{FirstName} ate {food} from {restaurant.Name}!");
        }


        public void Eat(List<LunchBuddy> companions)
        {
            Console.WriteLine($"{FirstName} {LastName} ate lunch with some friends:");
            foreach (var name in companions)
            {
                Console.WriteLine($"{name.FirstName}");
            }
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            Console.WriteLine($"{FirstName} is eating {food} with a few friends:");
            foreach (var name in companions)
            {
                Console.WriteLine($"{name.FirstName}");
            }
        }

    }
}
