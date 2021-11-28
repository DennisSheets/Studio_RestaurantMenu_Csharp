using System;
using System.Collections.Generic;
using System.Text;

namespace Ch4_studio_restaurantMenu
{
    internal class Restaurant
    {

        static void Main(string[] args)
        {
            Menu menu1 = new Menu("Eat Stuff");

            List<Item> emptyItems = new List<Item> {
                new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(),
                new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(), new Item(),
                new Item(), new Item()};
            
            foreach(Item item in emptyItems)
            {
                Console.WriteLine(item.ToString());
                menu1.addItem(item);
            }

            Item item1 = new Item("(2) ChicagoHot Dogs ", "A favorite. Two perfectly loaded Chicago sytle hot dogs", 6.79, "main course");
            Item item2 = new Item("Cheesy Mac & Cheese", "Mac & Cheese made from real WI Cheese, penne noodles", 9.95, "main course");
            Item item3 = new Item("Hot Hot Hot Wings", "(12) Wings with sauce direct from the depths of hell", 9.95, "appetizer");
            Item item4 = new Item("Chips and Salsa Bowl", "Fresh salsa and Stale Chips served with Ketchup Salsa", 6.95, "appetizer");
            Item item5 = new Item("Fried Dill Pickles", "Dill Pickles, fried and served with an Aoli Sauce", 8.95, "appetizer");
            Item item6 = new Item("Classic Cheese plate", "Soft and hard cheeses, served with green apple slices", 9.95, "dessert");
            Item item7 = new Item("Ohio Killer Brownie", "Direct from shitty shitty Ohio, the best brownie ever", 8.95, "dessert");
            Item item8 = new Item("name", "description", 0, "dessert");
            item8.IsHidden = true;
            
            menu1.addItem(item1);
            menu1.addItem(item2);
            menu1.addItem(item3);
            menu1.addItem(item4);
            menu1.addItem(item5);
            menu1.addItem(item6);
            menu1.addItem(item7);
            menu1.addItem(item8);   

            run();


            void logic() {
                string error = "\t\t !!!!!   NOT A VALID SELECTION   !!!!!";
                Menu menu = menu1;
                List<Item> items = menu.Items;
                
                try
                {
                    int selection = HelperMethods.menuOptions();
                    if (selection >= 1 || selection <= 5)
                    {
                        if (selection == 1)
                        {
                            HelperMethods.UpdateTitle(menu);
                            run();
                        }
                        else if (selection == 2)
                        {
                            if (menu.AvailSpace() >= 1)
                            {
                                HelperMethods.AddItem(items);
                                run();
                            }
                            else 
                            {
                                Console.WriteLine("Menu is full! You'll need to remove or edit an exiting item");
                                logic();
                            }
                        }
                        else if (selection == 3) 
                        {
                            int index = HelperMethods.IndexFromList(items, selection);
                            HelperMethods.DeleteHideItem(items[index-1]);
                            run();
                        }
                        else if (selection == 4)
                        {
                            int index = HelperMethods.IndexFromList(items,selection);
                            HelperMethods.EditItem(items[index-1]);
                            run();
                        }
                        else if (selection == 5) 
                        {
                            run();
                        }
                        else
                        {
                            Console.WriteLine($"{error}");
                            logic();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{error}");
                    logic();
                }
            }

            void run()
            {
                Console.Clear();
                menu1.printMenu();
                logic();
            }
        }
    }
}
