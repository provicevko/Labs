
namespace Lab7
{
    public interface IMyList<T>
    {
        void Add(T value);
        void DeleteAfterMax();
        int FiveKrat();
    }
}