namespace IteratorAndCompositeExercise.Interfaces
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
        void Remove();
    }
}
