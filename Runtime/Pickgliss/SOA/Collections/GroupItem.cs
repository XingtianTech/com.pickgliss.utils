namespace Pickgliss.SOA.Collections
{
    public class GroupItem : UnityEngine.MonoBehaviour
    {
        public Group group;

        protected virtual void OnEnable()
        {
            group.Add(this);
        }

        protected virtual void OnDisable()
        {
            group.Remove(this);
        }
    }
} 