using UnityEngine;
namespace Pickgliss.Pool
{
    public class Pooled : MonoBehaviour
    {
        public PrefabPool pool;
        public void Release()
        {
            pool.Release(gameObject);
        }
    }
}