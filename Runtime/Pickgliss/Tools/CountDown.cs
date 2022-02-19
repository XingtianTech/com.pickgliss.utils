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
        private WaitForSeconds _waitForSeconds;
        private void Awake()
        {
            _waitForSeconds = new WaitForSeconds(second);
        }

        private IEnumerator Start()
        {
            yield return _waitForSeconds;
            onTimeUp?.Invoke();
        }
    }

}
