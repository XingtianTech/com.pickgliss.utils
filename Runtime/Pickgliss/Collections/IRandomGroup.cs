
namespace Pickgliss.Collections
{
    public interface IRandomGroup<T0>
    {
        T0 GetRandomOne();
        T0 GetRandomOne(T0 exclude);
    }
}