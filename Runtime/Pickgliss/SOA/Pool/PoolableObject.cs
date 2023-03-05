
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Pool
{

    public class PoolableObject : MonoBehaviour
    {
        public ObjectPool Parent;

        public virtual void OnDisable()
        {
            Parent.ReturnObjectToPool(this);
        }
    }
}