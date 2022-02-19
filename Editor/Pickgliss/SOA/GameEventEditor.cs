using Pickgliss.SOA.Events;
using UnityEngine;

namespace UnityEditor.Pickgliss.SOA
{
    [CustomEditor(typeof(GameEvent), true)]
    public class GameEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var e = target as GameEvent;
            if (GUILayout.Button("Raise"))
            {
                if (e != null) e.Raise();
            }
                
        }
    }
}