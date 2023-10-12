using IteratorAndCompositeExercise.Interfaces;
using IteratorAndCompositeExercise.Models;

namespace IteratorAndCompositeExercise.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] MenuItems;
        int position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            MenuItems = menuItems;
        }

        public object Next()
        {
            MenuItem menuItem = MenuItems[position];
            position++;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= MenuItems.Length || MenuItems[position] == null)
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
                for (int i = position - 1; i < (MenuItems.Length - 1); i++)
                {
                    MenuItems[i] = MenuItems[i + 1];
                }
                MenuItems[MenuItems.Length - 1] = null;
            }
        }
    }

}
