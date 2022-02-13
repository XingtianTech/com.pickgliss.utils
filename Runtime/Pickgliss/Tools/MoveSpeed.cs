using Pickgliss.SOA.Variables;
using UnityEngine;

namespace Pickgliss.Tools
{
    public class MoveSpeed : MonoBehaviour
    {
        public VariableReference<float> speed;
        public int Going => (int)Mathf.Sign(speed);
    }
}