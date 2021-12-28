namespace Pickgliss.PrefabPool
{
    public class Pooled : UnityEngine.MonoBehaviour
    {
        public PrefabPool pool;
        public void Release()
        {
            pool.Release(gameObject);
        }
    }
}