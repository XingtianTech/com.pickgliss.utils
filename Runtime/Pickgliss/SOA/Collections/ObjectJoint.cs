namespace Pickgliss.SOA.Collections
{
    public class ObjectJoint : UnityEngine.MonoBehaviour
    {
        public ObjectRef objectRef;
        public void Awake()
        {
            objectRef.SetObject(gameObject);
        }
    }
}