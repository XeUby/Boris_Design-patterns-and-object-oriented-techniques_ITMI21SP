namespace IteratorAndCompositeExercise.Interfaces
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
        void Remove();
    }
}
