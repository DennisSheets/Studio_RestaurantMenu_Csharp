using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class Item
    {

        public static int NextID = 1;
        public int ID { get;}
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsNew { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHidden { get; set; }

        public Item(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            DateCreated = DateTime.Now;
            IsNew = false;
            IsEmpty = false;
            IsHidden = false;
            ID = NextID;
            NextID++;

        }

        public Item() {
            
            IsNew=false;
            IsEmpty = true;
            IsHidden=false;
            ID = NextID;
            NextID++;
        }

        public override string ToString()
        {
            return $"ID:{ID}  Name:{Name} Price:{Price}";
        }

        public override bool Equals(object obj)
        {
            return obj is Item item &&
                   ID == item.ID &&
                   Name == item.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name);
        }
    }
}
