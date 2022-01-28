
using UnityEngine;

namespace Pickgliss.Collections
{
    public interface IRandomObject
    {
        GameObject GetRandomOne();
        GameObject GetRandomOne(GameObject exclude);
    }
}