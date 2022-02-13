using Pickgliss.SOA.Events;
using UnityEditor;
using UnityEngine;

namespace Pickgliss.SOA.Editor
{
    [CustomEditor(typeof(GameEvent), true)]
    public class EventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}