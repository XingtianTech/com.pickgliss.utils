using System.Collections;
using Pickgliss.SOA.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.Tools
{
    public class Timer : MonoBehaviour
    {
        public VariableReference<int> times;
        public VariableReference<float> interval;
        public UnityEvent onTimer;
        IEnumerator Start()
        {
            for (int i = 0; i < times; i++)
            {
                onTimer?.Invoke();
                yield return new WaitForSeconds(interval);
            }
        }
    }
}