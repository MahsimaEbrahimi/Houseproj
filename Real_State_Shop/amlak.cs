using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_State_Shop
{
    class amlak
    {
        private int Age;
        private int Meterage;
        private string Type_of_service;
        private int Number_rooms;
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetMeterage()
        {
            return Meterage;
        }
        public void SetMeterage(int meterage)
        {
            Meterage = meterage;
        }

        public string Get_Type_of_service()
        {
            return Type_of_service;
        }
        public void Set_Type_of_service(string type_of_service)
        {
            Type_of_service = type_of_service;
        }

        public int GetNumber_rooms()
        {
            return Number_rooms;
        }
        public void SetNumber_rooms(int rooms)
        {
            Number_rooms = rooms;
        }

    }
}
