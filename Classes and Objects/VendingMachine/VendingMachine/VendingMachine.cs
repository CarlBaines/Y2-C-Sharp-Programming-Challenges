using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    public class vendingMachine
    {
        //attributes
        private int chocolateStock;

        private int crispsStock;

        private int waterStock;

        public vendingMachine(int initialChocStock, int initialCrispsStock, int initialWaterStock)
        {
            chocolateStock = initialChocStock;
            crispsStock = initialCrispsStock;
            waterStock = initialWaterStock;
        }

        public bool BuyChocolate(int quantity)
        {
            if (chocolateStock >= quantity)
            {
                chocolateStock -= quantity;
                return true;
            } else
            {
                return false;
            }
        }

        public bool BuyCrisps(int quantity)
        {
            if (crispsStock >= quantity)
            {
                crispsStock -= quantity;
                return true;
            } else
            {
                return false;
            }
        }

        public bool BuyWater(int quantity)
        {
            if (waterStock >= quantity)
            {
                waterStock -= quantity;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
