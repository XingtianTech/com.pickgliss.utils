using System;
using Pickgliss.SOA.Variables;
using UnityEngine;

namespace Pickgliss.Tools
{
    [RequireComponent(typeof(MoveSpeed))]
    public class MoveTowards : MonoBehaviour
    {
        public Transform target;
        private MoveSpeed _moveSpeed;
        private void Awake()
        {
            _moveSpeed = GetComponent<MoveSpeed>();
        }

        void Update()
        {
            if (target == null) return;
            // Move our position a step closer to the target.
            var step =  _moveSpeed.speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}