using System.Collections;
using Pickgliss.SOA.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.Tools
{
    public class CountDown : MonoBehaviour
    {
        public VariableReference<float> second;
        public UnityEvent onTimeUp;

        IEnumerator Start()
        {
            yield return new WaitForSeconds(second);
            onTimeUp?.Invoke();
        }
    }

}
