using Pickgliss.SOA.Set;

namespace Pickgliss.SOA.Authoring.cs
{
    public class Thing : UnityEngine.MonoBehaviour
    {
        public ThingRuntimeSet RuntimeSet;

        private void OnEnable()
        {
            RuntimeSet.Add(this);
        }

        private void OnDisable()
        {
            RuntimeSet.Remove(this);
        }
    }
}