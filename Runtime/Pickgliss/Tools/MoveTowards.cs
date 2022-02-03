using Pickgliss.SOA.Variables;
using UnityEngine;

namespace Pickgliss.Tools
{
    public class MoveTowards : MonoBehaviour
    {
        public VariableReference<float> speed;
        public Transform target;
        
        public int Going => (int)Mathf.Sign(speed);
        void Update()
        {
            if (target == null) return;
            // Move our position a step closer to the target.
            var step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}