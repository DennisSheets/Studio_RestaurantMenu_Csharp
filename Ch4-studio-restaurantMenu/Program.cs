using System;

namespace Ch4_studio_restaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu1 = new Menu("Eat Stuff");

            Item item1 = new Item("(2) ChicagoHot Dogs ", "A favorite. Two perfectly loaded Chicago sytle hot dogs", 6.79, "main course");
            Item item2 = new Item("Cheesy Mac & Cheese", "Mac & Cheese made from real WI Cheese, penne noodles", 9.95, "main course");
            Item item3 = new Item("Hot Hot Hot Wings", "(12) Wings with sauce direct from the depths of hell", 9.95, "appetizer");
            Item item4 = new Item("Chips and Salsa Bowl", "Fresh salsa and Stale Chips served with Ketchup Salsa",6.95,"appetizer");
            Item item5 = new Item("Fried Dill Pickles", "Dill Pickles, fried and served with an Aoli Sauce", 8.95, "appetizer");
            Item item6 = new Item("Classic Cheese plate", "Soft and hard cheeses, served with green apple slices", 9.95, "dessert");
            Item item7 = new Item("Ohio Killer Brownie", "Direct from shitty shitty Ohio, the best brownie ever", 8.95, "dessert");

            menu1.addItem(item1);
            menu1.addItem(item2);
            menu1.addItem(item3);
            menu1.addItem(item4);
            menu1.addItem(item5);
            menu1.addItem(item6);
            menu1.addItem(item7);

            menu1.printMenu();
            

        }
    }
}
