using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class Item
    {
  
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime DateCreated { get; set; }
        public Boolean IsNew { get; set; }

        public Item(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsNew = false;
            DateCreated = DateTime.Now; 
        }


    }
}
