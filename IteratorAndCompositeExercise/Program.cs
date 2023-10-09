using System.Collections;

namespace IteratorAndCompositeExercise
{
    // For this exercise try complete the Iterator and Composite example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 9 the Iterator and Composite Patterns (starts at page 315)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class MenuItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Vegetarian { get; set; }
            public double Price { get; set; }

            public MenuItem(string name, string description, bool vegetarian, double price) 
            { 
                Name = name;
                Description = description;
                Vegetarian = vegetarian;
                Price = price;
            }

            public string GetName()
            {
                return Name;
            }

            public string GetDescription()
            {
                return Description;
            }

            public Boolean GetVegetarian()
            {
                return Vegetarian;
            }

            public double GetPrice()
            {
                return Price;
            }
        }

        public class PancakeHouseMenu
        {
            public ArrayList MenuItems { get; set; }

            public PancakeHouseMenu()
            {
                MenuItems = new ArrayList();

                AddItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", false, 2.99);
            }

            public void AddItem(string name, string description, bool vegetarian, double price)
            {
                MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
                MenuItems.Add(menuItem);
            }

            public ArrayList GetMenuItems()
            {
                return MenuItems;
            }
        }

        public class DinerMenu
        {
            private int Max_Items = 6;
            int numberOfItems = 0;
            MenuItem[] MenuItems;

            public DinerMenu()
            {
                MenuItems = new MenuItem[Max_Items];

                AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            }

            public void AddItem(string name, string description, bool vegetarian, double price)
            {
                MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
                if (numberOfItems >= Max_Items)
                {
                    Console.WriteLine("Sorry, menu is full! Can't add item to menu");
                } else
                {
                    MenuItems[numberOfItems] = menuItem;
                    numberOfItems++;
                }
            }

            public MenuItem[] GetMenuItems()
            {
                return MenuItems;
            }
        }
    }
}