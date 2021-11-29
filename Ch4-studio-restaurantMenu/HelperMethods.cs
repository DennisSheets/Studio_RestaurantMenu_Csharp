using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class HelperMethods
    {

        public static string ErrorCode()
        {
            Random random = new Random();
            int index = random.Next(0, Error.code.Count);
            return Error.code[index];
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
                $"\t\t5 - DISPLAY the menu\n" +
                $"\t\t6 - DISPLAY and item\n");

            return int.Parse(Console.ReadLine());
        }

        public static void DisplayItem(Item item)
        {
            Console.WriteLine($"\n" +
                $"\t\tName:        {item.Name}\n" +
                $"\t\tDescription: {item.Description}\n" +
                $"\t\tPrice:       {item.Price}\n" +
                $"\t\tCategory:    {item.Category}\n" +
                $"\t\tisEmpty:     {item.IsEmpty}\n" +
                $"\t\tisNew:       {item.IsNew}\n" +
                $"\t\tisHidden:    {item.IsHidden}\n");
        }
 


        public static void UpdateTitle(Menu menu)
        {
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\tEnter the new Title");
            Console.ResetColor();
            string newName = Console.ReadLine();
            if (newName == "")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["titleChange"]}");
                Console.ResetColor();
                UpdateTitle(menu);
            }
            else
            {
                menu.rename(newName);
            }
        }

        public static string ItemName()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\tEnter the new item's name: ");
            Console.ResetColor();
            string itemName = Console.ReadLine();
            if (itemName == "")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["itemName"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                ItemName();
            }
            return itemName;
        }

        public static string ItemDescription()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\tEnter the new item's description: ");
            Console.ResetColor();
            string itemDescription = Console.ReadLine();
            if (itemDescription == "")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["itemDescription"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                ItemDescription();
            }
            return itemDescription;
        }

        public static double ItemPrice()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\tEnter the new item's price: ");
            Console.ResetColor();
            string itemPrice = Console.ReadLine();
            Console.WriteLine(double.Parse(itemPrice));
            try
            {
                double.Parse(itemPrice);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["itemPrice"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                ItemPrice();
            }
            return double.Parse(itemPrice);
        }

        public static string ItemCategory()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\tEnter 1-3 for the new Item's Category: \n");
            Console.ResetColor();
            Console.WriteLine($"\t\t1 - appetizer\n" +
                                "\t\t2 - main course\n" +
                                "\t\t3 - desert\n");
            string itemCategory = Console.ReadLine();
            try
            {
                int.Parse(itemCategory);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["itemCategory"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                ItemCategory();
            }

            if (itemCategory == "" || int.Parse(itemCategory) < 1 || int.Parse(itemCategory) > 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["itemCategory"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                ItemCategory();
            }
            if (int.Parse(itemCategory) == 1)
            {
                return Menu.Categories[0];
            }
            else if (int.Parse(itemCategory) == 2)
            {
                return Menu.Categories[1];
            }
            else
            {
                return Menu.Categories[2];
            }

        }

        public static bool NewItem()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\tDo you want this tagged as a NEW item? Enter 1 or 2. \n ");
            Console.ResetColor();
            Console.WriteLine($"\t\t1 - yes\n" +
                                $"\t\t2 - no\n");
            string newSelection = Console.ReadLine();
            
            try
            {
                int.Parse(newSelection);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["newItem"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                NewItem();
            }
            if (newSelection == "" || int.Parse(newSelection) < 1 || int.Parse(newSelection) > 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\t{HelperMethods.ErrorCode()}");
                Console.WriteLine($"\t{Error.errors["newItem"]}");
                Console.ResetColor();
                Console.WriteLine("\n");
                NewItem();
            }
            if (int.Parse(newSelection) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static void AddItem(List<Item> list)
        {
            int index = list.FindIndex(x => x.IsEmpty == true);
            list[index].Name = ItemName(); 
            list[index].Description = ItemDescription();
            list[index].Price = ItemPrice();
            list[index].Category = ItemCategory();
            list[index].IsEmpty = false;
            list[index].IsNew = NewItem();
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
            if      (int.Parse(categorySelection) == 1) { itemCategory = Menu.Categories[0]; }
            else if (int.Parse(categorySelection) == 2) { itemCategory = Menu.Categories[1]; }
            else if (int.Parse(categorySelection) == 3) { itemCategory = Menu.Categories[2]; }
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
