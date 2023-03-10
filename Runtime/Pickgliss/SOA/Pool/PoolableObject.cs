
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Pool
{
    [AddComponentMenu( "SOA/sssss" )]
    public class PoolableObject : MonoBehaviour
    {
        public ObjectPool Parent;

        public virtual void OnDisable()
        {
            Parent.ReturnObjectToPool(this);
        }
    }
}