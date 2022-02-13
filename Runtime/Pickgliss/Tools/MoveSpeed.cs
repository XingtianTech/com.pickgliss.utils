using Pickgliss.SOA.Variables;
using UnityEngine;

namespace Pickgliss.Tools
{
    public class MoveSpeed : MonoBehaviour
    {
        public const float Precision = 0.001f;
        public VariableReference<float> speed;
        public int Going => (int)Mathf.Sign(speed);
    }
}