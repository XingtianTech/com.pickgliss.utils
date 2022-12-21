using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    [CreateAssetMenu(menuName = "Utils/ObjectRef")]
    public class ObjectRef : ScriptableObject
    {
        private GameObject _ori;
        public void SetObject(GameObject ori)
        {
            _ori = ori;
        }
        public Transform transform => _ori.transform;

        public GameObject Ori => _ori;
    }
}