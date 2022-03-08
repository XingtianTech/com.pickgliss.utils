using System;
using Pickgliss.Extension;
using UnityEditor;
using UnityEngine;
namespace Pickgliss.Tools
{
    public class PlaceRelativeLocation : MonoBehaviour
    {
        [HideInDerived]
        public GameObject relative;
        public MonoScript anchor;
        public Vector3 offset;
        private Type _anchorType;
        
        protected virtual void Awake()
        {
            if (anchor == null) return;
            _anchorType = anchor.GetClass();
        }

        protected virtual void Start()
        {
            SetupPosition();
        }

        protected void SetupPosition()
        {
            if (anchor == null)
            {
                transform.position = relative.transform.position+offset;
            }
            else
            {
                var com = relative.GetComponentInChildren(_anchorType);
                transform.position = com.transform.position+offset;
            }
        }
        
    }
}