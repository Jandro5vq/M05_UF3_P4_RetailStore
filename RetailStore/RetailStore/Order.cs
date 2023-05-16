using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    internal class Order
    {
        public int Number;
        public string Date;
        public Product Product;
        public int Quantity;
        public float FianlPrice;
        public User User;
        public bool Pending;
    }
}
