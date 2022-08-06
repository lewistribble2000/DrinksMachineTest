using System;
using System.Collections.Generic;
using System.Text;

namespace DrinksMachine.Models
{
    public class Drinks
    {
        private int lemonTeaCount;
        public int LemonTeaCount
        {
            get
            {
                return lemonTeaCount;
            }
            set
            {
                lemonTeaCount++;
            }
        }

        private int coffeeCount;
        public int CoffeeCount
        {
            get
            {
                return coffeeCount;
            }
            set
            {
                coffeeCount++;
            }
        }

        private int hotChocolateCount;
        public int HotChocolateCount
        {
            get
            {
                return hotChocolateCount;
            }
            set
            {
                hotChocolateCount++;
            }
        }
    }
}
