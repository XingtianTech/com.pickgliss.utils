namespace Pickgliss.SOA.Selector
{
    public class SingleSelector<T> : GroupSelector<T> where T :class
    {
        
        public T item;
        public override T NextOne()
        {
            return item;
        }
    }
}