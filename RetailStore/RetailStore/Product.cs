using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    internal class Product
    {
        public int ID;
        public bool Visible;
        public string Name;
        public string Brand;
        public List<string> Images;
        public string Description;
        public float BasePrice;
        public bool Discount;
        public List<Comment> Comments;

    }
}
