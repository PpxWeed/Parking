using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer client = new Customer("Jackson", 245456, 10, 10);
            Console.WriteLine(client.calculateCharges());
        }
    }
}
