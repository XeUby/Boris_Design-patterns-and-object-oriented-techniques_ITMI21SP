using IteratorAndCompositeExercise.Interfaces;
using IteratorAndCompositeExercise.Iterators;
using System.Collections;

namespace IteratorAndCompositeExercise.Models
{
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

    public class PancakeHouseMenu : IMenu
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

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(MenuItems);
        }
    }


    public class DinerMenu : IMenu
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
            }
            else
            {
                MenuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(MenuItems);
        }
    }


    public class Waitress
    {
        IMenu PancakeHouseMenu;
        IMenu DinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator PancakeIterator = PancakeHouseMenu.CreateIterator();
            IIterator DinerIterator = DinerMenu.CreateIterator();
            Console.WriteLine("Menu - breakfast");
            PrintMenu(PancakeIterator);
            Console.WriteLine("Menu - Lunch");
            PrintMenu(DinerIterator);

        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem MenuItem = (MenuItem)iterator.Next();
                Console.WriteLine(MenuItem.GetName());
                Console.WriteLine(MenuItem.GetPrice());
                Console.WriteLine(MenuItem.GetDescription());
            }
        }
    }
}
