using System.Collections;
using Pickgliss.SOA.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.Tools
{
    public class Timer : MonoBehaviour
    {
        public bool invokeWhenStart = true;
        public VariableReference<int> times;
        public VariableReference<float> interval;
        public UnityEvent onTimer;
        IEnumerator Start()
        {
            var t = times.Value;
            if(invokeWhenStart)
            {
                onTimer?.Invoke();
                t --;
            }
            for (int i = 0; i < t; i++)
            {
                yield return new WaitForSeconds(interval);
                onTimer?.Invoke();
            }
        }
    }
}