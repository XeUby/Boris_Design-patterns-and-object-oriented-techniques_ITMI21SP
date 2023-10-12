using IteratorAndCompositeExercise.Interfaces;
using IteratorAndCompositeExercise.Models;
using System.Collections;

namespace IteratorAndCompositeExercise.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        ArrayList MenuItems;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            MenuItems = menuItems;
        }

        public object Next()
        {
            MenuItem menuItem = (MenuItem)MenuItems[position];
            position++;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= MenuItems.Count || MenuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Remove()
        {
            if (position <= 0)
            {
                throw new InvalidOperationException("You can't remove an item untill you've done at least one next()");
            }
            else if (MenuItems[position - 1] != null)
            {
                for (int i = position - 1; i < (MenuItems.Count - 1); i++)
                {
                    MenuItems[i] = MenuItems[i + 1];
                }
                MenuItems[MenuItems.Count - 1] = null;
            }
        }
    }
}
