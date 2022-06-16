using System;
using UnityEngine;
namespace Pickgliss.SOA.Variables
{
    public class VariableBase : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string developerDescription = "";
#endif
    }

}