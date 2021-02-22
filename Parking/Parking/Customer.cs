using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Customer
    {
        public string Client_car { get; }
        public long ID_car { get; }
        public float Arrival_time { get; set; }
        public int Hours { get; }

        public Customer(string _client_car, long _ID_car, float _Arrival, int _hour)
        {
            Client_car = _client_car;
            ID_car = _ID_car;
            Arrival_time= _Arrival;
            Hours= _hour;
        }
        public float calculateCharges()
        {
            if (Hours <= 3)
            {
                return 2f;
            }
            if (Hours >= 20)
            {
                return 10;
            }
            return 2 + (Hours + 3) * 0.5F;
        }
    }
}
