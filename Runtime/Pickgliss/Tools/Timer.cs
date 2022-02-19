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
        private WaitForSeconds _waitForSeconds;
        private void Awake()
        {
            _waitForSeconds = new WaitForSeconds(interval);
        }

        private IEnumerator Start()
        {
            var t = times.Value;
            if(invokeWhenStart)
            {
                onTimer?.Invoke();
                t --;
            }
            for (var i = 0; i < t; i++)
            {
                yield return _waitForSeconds;
                onTimer?.Invoke();
            }
        }
    }
}