using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class Menu
    {
        private List<Item> items = new List<Item>();
        private static List<string> categories = new List<string> { "appetizer","main course","dessert"};
        private DateTime lastUpdateTime { get; set; }
        private string MenuTitle { get; set; }

        public Menu(string menuTitle)
        {
            this.items = new List<Item>();
            this.lastUpdateTime = DateTime.Now;
            MenuTitle = menuTitle;
        }

        public void addItem(Item item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }

        public void deleteItem(Item item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }
        }

        public void printMenu()
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine($"Last updated on: {lastUpdateTime}\n");
            foreach (string category in categories)
            {
                Console.WriteLine($"\t{category}\n");
                foreach (Item item in items)
                {
                    if(item.Category == category)
                    {
                        Console.WriteLine($"\t\t{item.Name}\t{item.Description}\t\t${item.Price}");
                    }
                      
                }
                Console.WriteLine("\t");
            }
        }
    }
}
