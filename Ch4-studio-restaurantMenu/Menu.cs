using System;
using System.Collections.Generic;

namespace Ch4_studio_restaurantMenu
{
    internal class Menu
    {
        public List<Item> Items { get; set; }
        public readonly static List<string> categories = new List<string> { "appetizer", "main course", "dessert" };
        public DateTime LastUpdateTime { get; set; }
        public string MenuTitle { get; set; }
        
        public int AvailSpace()
        {
            int total = 0;
            foreach(Item item in Items)
            {
                if (item.IsEmpty)
                {
                    total++;
                }
            }
            return total;
        }

        public Menu(string menuTitle)
        {
            Items = new List<Item>();
            LastUpdateTime = DateTime.Now;
            MenuTitle = menuTitle;
        }

        public void addItem(Item item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
                LastUpdateTime = DateTime.Now;
            }
        }

        public void removeItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                LastUpdateTime = DateTime.Now;
            }
        }

        public void isNew(Item item)
        {
            item.IsNew = !item.IsNew;
            LastUpdateTime = DateTime.Now;
        }

        public void editItem(Item item, string name,string description,double price)
        {
            if (name != "") { item.Name = name;}
            if (description != "") {item.Description = description;}
            if (price != null) { item.Price = price; }
        }

        public void rename(string newName)
        {
            this.MenuTitle = newName;
            LastUpdateTime = DateTime.Now;
        }


        public void printMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n\n\t\t\t {MenuTitle}     updated : {LastUpdateTime}\n");
            Console.ResetColor();
            foreach (string category in categories)
            {
                Console.WriteLine($"\t{category.ToUpper()}\n");
                foreach (Item item in Items)
                {
                    if (item.Category == category && item.IsHidden == false)
                    {
                        if (item.IsNew)
                        {
                            Console.WriteLine($"\t\t{item.Name}\t{item.Description}\t\t${item.Price}  NEW");
                        }
                        else
                        {
                            Console.WriteLine($"\t\t{item.Name}\t{item.Description}\t\t${item.Price}");
                        } 
                    }
                }
                Console.WriteLine("\t");
            }
        }
    }
}
