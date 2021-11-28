using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class HelperMethods
    {

        public static void ErrorCode()
        {
            Random random = new Random();
            int index = random.Next(0,Error.code.Count);
            Console.WriteLine(Error.code[index]);
        }

        public static int menuOptions()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n\n" +
                $"\tWhat would you like to do?");
            Console.ResetColor();
            Console.WriteLine($"\n" +
                $"\t\t1 - EDIT menu title\n" +
                $"\t\t2 - ADD a new item to the menu\n" +
                $"\t\t3 - DELETE or HIDE an item\n" +
                $"\t\t4 - EDIT an item\n" +
                $"\t\t5 - DISPLAY the menu\n");

            return int.Parse(Console.ReadLine());
        }


        public static void UpdateTitle(Menu menu)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\tEnter the new Title");
            Console.ResetColor();
            Console.WriteLine("\n");
            string newName = Console.ReadLine();
            menu.rename(newName);
        }


        public static int IndexFromList(List<Item> list, int selection)
        {
            if (selection == 3)
                { Console.WriteLine("Enter the ID: of the Item that you want to Delete or Hide"); }
            else
                { Console.WriteLine("Enter the ID: of the Item that you want to Edit? "); }

            foreach (Item item in list)
            {
                if (!item.IsEmpty)
                    if (!item.IsHidden) 
                        { 
                            Console.Write("\t" + item.ToString() + "\n");
                        }
                    else 
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Write("\t" + item.ToString() + "     --HIDDEN FROM MENU--");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("\n");
                    }
            }
            string itemToEdit = Console.ReadLine();
            return int.Parse(itemToEdit);
        }


        public static void AddItem(List<Item> list)
        {
            Console.WriteLine($"\tEnter the new item's name: ");
            string itemName = Console.ReadLine();

            Console.WriteLine($"\tEnter the new item's description");
            string itemDescription = Console.ReadLine();

            Console.WriteLine($"\tEnter the new item's price");
            string itemPrice = Console.ReadLine();

            Console.WriteLine($"\tCategory: \n" +
                "\t\t1 - appetizer\n" +
                "\t\t2 - main course\n" +
                "\t\t3 - desert\n");
            int categorySelection = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\tDo you want this tagged as a NEW item? \n " +
                $"\t\t1 - yes\n" +
                $"\t\t2 - no\n");
            int newSelection = int.Parse(Console.ReadLine());

            bool itemSetAsNew;
            if (newSelection == 1) 
                { itemSetAsNew = true; }
            else 
                { itemSetAsNew = false; }

            string itemCategory;
            if (categorySelection == 1) 
                { itemCategory = Menu.categories[0]; }
            else if (categorySelection == 2) 
                { itemCategory = Menu.categories[1]; }
            else if (categorySelection == 3) 
                { itemCategory = Menu.categories[2]; }
            else 
                { itemCategory = "\tWhat the fuck is this"; }

            int index = list.FindIndex(x => x.IsEmpty == true);
            if (itemName != "")
                { list[index].Name = itemName; }
            if (itemDescription != "") 
                { list[index].Description = itemDescription; }
            if (itemPrice != "")       
                { list[index].Price = double.Parse(itemPrice); }
            if (itemCategory != "")    
                { list[index].Category = itemCategory; }
            list[index].IsEmpty = false;
            list[index].IsNew = itemSetAsNew;
        }


        public static void EditItem(Item item)
        {
            Console.WriteLine($"\t{item.Name}:  Type a new name or press 'Enter' to keep this name");
            string itemName = Console.ReadLine();

            Console.WriteLine($"\t{item.Description}: Type a new description or press 'Enter' to keep this description");
            string itemDescription = Console.ReadLine();

            Console.WriteLine($"\t{item.Price}: Type a new price or press 'Enter' to keep this price");
            string itemPrice = Console.ReadLine();

            Console.WriteLine($"\t{item.Category}: Enter the Category ID, or press 'Enter' to keep this category: \n" +
                "\t\t1 - appetizer\n" +
                "\t\t2 - main course\n" +
                "\t\t3 - desert\n");
            string categorySelection = Console.ReadLine();

            Console.WriteLine($"\tDo you want this tagged as a NEW item? \n " +
                "\t1 - yes\n" +
                "\t2 - no\n");
            string newSelection = Console.ReadLine();

            string itemCategory;
            if      (int.Parse(categorySelection) == 1) { itemCategory = Menu.categories[0]; }
            else if (int.Parse(categorySelection) == 2) { itemCategory = Menu.categories[1]; }
            else if (int.Parse(categorySelection) == 3) { itemCategory = Menu.categories[2]; }
            else                                        { itemCategory = "What the fuck is this"; }

            if (itemName != "")             { item.Name = itemName; }
            if (itemDescription != "")      { item.Description = itemDescription; }
            if (itemPrice != "")            { item.Price = double.Parse(itemPrice); }
            if (categorySelection != "")    { item.Category = itemCategory; }
            if (int.Parse(newSelection) == 1 && newSelection != "")         { item.IsNew = true; }
            else if (int.Parse(newSelection) == 2 && newSelection != "")    { item.IsNew = false; }
                                                                             item.IsEmpty = false;
            
        }

        public static void DeleteHideItem(Item item)
        {
            Console.WriteLine($"\tDo you want to HIDE or DELETE the item: {item} \n " +
                "\t\t1 - delete\n" +
                "\t\t2 - hide\n");
            string deleteHiden = Console.ReadLine();
            if (int.Parse(deleteHiden) == 1)
            {
                Console.WriteLine("\tIf you are sure you want to delete, type 'DELETE' to confirm");
                string confirmDelete = Console.ReadLine();
                if(confirmDelete == "DELETE")
                {
                    item.Name = "";
                    item.Description = "";
                    item.Price = 0.0;
                    item.Category = "";
                    item.IsEmpty = true;
                    item.IsNew = false;
                }
            }
            else if (int.Parse(deleteHiden) == 2) 
            {
                item.IsHidden = true;
            }
        }
    }
}
