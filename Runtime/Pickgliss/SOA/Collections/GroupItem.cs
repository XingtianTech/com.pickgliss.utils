namespace Pickgliss.SOA.Collections
{
    public class GroupItem : UnityEngine.MonoBehaviour
    {
        public Group group;

        private void OnEnable()
        {
            group.Add(this);
        }

        private void OnDisable()
        {
            group.Remove(this);
        }
    }
} 