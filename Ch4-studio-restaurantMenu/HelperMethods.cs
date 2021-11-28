using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class HelperMethods
    {
        public static int menuOptions()
        {
            Console.WriteLine($"\n\n" +
                $"What would you like to do?\n" +
                $"\t1 - edit menu title\n" +
                $"\t2 - add a new item to the menu\n" +
                $"\t3 - remove an item from the menu\n" +
                $"\t4 - edit and item\n" +
                $"\t5 - display the menu\n");
            return int.Parse(Console.ReadLine());
        }


        public static void UpdateTitle(Menu menu)
        {
            Console.WriteLine("Enter the new Title");
            string newName = Console.ReadLine();
            menu.rename(newName);
        }





        public static void AddNewItem(List<Item> list)
        {
            Console.WriteLine("Enter the new item's name: ");
            string itemName = Console.ReadLine();

            Console.WriteLine("Enter the new item's description");
            string itemDescription = Console.ReadLine();

            Console.WriteLine("Enter the new item's price");
            string itemPrice = Console.ReadLine();

            Console.WriteLine("Category: \n" +
                "\t1 - appetizer\n" +
                "\t2 - main course\n" +
                "\t3 - desert\n");
            int categorySelection = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you want this tagged as a NEW item? \n " +
                "\t1 - yes" +
                "\t2 - no");
            int newSelection = int.Parse(Console.ReadLine());

            bool itemSetAsNew;
            if (newSelection == 1) { itemSetAsNew = true; }
            else { itemSetAsNew = false; }

            string itemCategory;
            if (categorySelection == 1) { itemCategory = Menu.categories[0]; }
            else if (categorySelection == 2) { itemCategory = Menu.categories[1]; }
            else if (categorySelection == 3) { itemCategory = Menu.categories[2]; }
            else { itemCategory = "What the fuck is this"; }

            int index = list.FindIndex(x => x.IsEmpty == true);
            if (itemName != "") { list[index].Name = itemName; }
            if (itemDescription != "") { list[index].Description = itemDescription; }
            if (itemPrice != "") { list[index].Price = double.Parse(itemPrice); }
            if (itemCategory != "") { list[index].Category = itemCategory; }
            list[index].IsEmpty = false;
            list[index].IsNew = itemSetAsNew;
        }


        public static int ListItems(List<Item> list)
        {
            Console.WriteLine("Enter the ID: of the Item that  would you like to edit? ");
            foreach (Item item in list)
            {
                if(!item.IsEmpty) 
                {
                    Console.Write("\t" + item.ToString() + "\n");
                }
            }
            string itemToEdit = Console.ReadLine();
            return int.Parse(itemToEdit);
        }


        public static void EditItem(Item item)
        {
            Console.WriteLine($"{item.Name}:  Type a new name or press 'Enter' to keep this name");
            string itemName = Console.ReadLine();

            Console.WriteLine($"{item.Description}: Type a new description or press 'Enter' to keep this description");
            string itemDescription = Console.ReadLine();

            Console.WriteLine($"{item.Price}: Type a new price or press 'Enter' to keep this price");
            string itemPrice = Console.ReadLine();

            Console.WriteLine($"{item.Category}: Enter the Category ID, or press 'Enter' to keep this category: \n" +
                "\t1 - appetizer\n" +
                "\t2 - main course\n" +
                "\t3 - desert\n");
            string categorySelection = Console.ReadLine();

            Console.WriteLine("Do you want this tagged as a NEW item? \n " +
                "\t1 - yes\n" +
                "\t2 - no\n");
            string newSelection = Console.ReadLine();

            string itemCategory;
            if (int.Parse(categorySelection) == 1) { itemCategory = Menu.categories[0]; }
            else if (int.Parse(categorySelection) == 2) { itemCategory = Menu.categories[1]; }
            else if (int.Parse(categorySelection) == 3) { itemCategory = Menu.categories[2]; }
            else { itemCategory = "What the fuck is this"; }

            if (itemName != "") { item.Name = itemName; }
            if (itemDescription != "") { item.Description = itemDescription; }
            if (itemPrice != "") { item.Price = double.Parse(itemPrice); }
            if (categorySelection != "") { item.Category = itemCategory; }
            if (int.Parse(newSelection) == 1 && newSelection != "") { item.IsNew = true; }
            else if (int.Parse(newSelection) == 2 && newSelection != "") { item.IsNew = false; }

            item.IsEmpty = false;
            
        }
    }
}
