using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_State_Shop
{
    class apartment: amlak
    {
        private int Number_floor;
        //private int amount_mortgage;
        //private int amount_rent;

        public int GetNumber_floor()
        {
            return Number_floor;
        }
        public void SetNumber_floor(int floor)
        {
            Number_floor = floor;
        }

       /* public int Getamount_mortgage()
        {
            return amount_mortgage;
        }
        public void Setamount_mortgage(int mortagage)
        {
            amount_mortgage = mortagage;
        }

        public int Getamount_rent()
        {
            return amount_mortgage;
        }
        public void Setamount_rent(int rent)
        {
            amount_rent = rent;
        }*/
    }
}
