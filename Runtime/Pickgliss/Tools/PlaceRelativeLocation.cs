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
        protected Type anchorType;
        
        protected virtual void Awake()
        {
            anchorType = anchor.GetClass();
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
                var com = relative.GetComponentInChildren(anchorType);
                transform.position = com.transform.position+offset;
            }
        }
        
    }
}