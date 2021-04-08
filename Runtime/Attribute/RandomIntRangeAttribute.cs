using UnityEngine;
using UnityEditor;
namespace Pickgliss.Attribute
{
    public class RandomIntRangeAttribute : PropertyAttribute
    {
        public int minLimit;
        public int maxLimit;

        public RandomIntRangeAttribute(int minLimit, int maxLimit)
        {
            this.minLimit = minLimit;
            this.maxLimit = maxLimit;
        }
    }
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(RandomIntRangeAttribute))]
    public class RandomIntRangeDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight;
        }

        // Draw the property inside the given rect
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            EditorGUI.EndProperty();

            RandomIntRangeAttribute range = attribute as RandomIntRangeAttribute;
            SerializedProperty minValue = property.FindPropertyRelative("x");
            SerializedProperty maxValue = property.FindPropertyRelative("y");
            float newMin = minValue.intValue;
            float newMax = maxValue.intValue;

            float labelWidthStart = 40.0f;
            float labelWidthEnd = 40.0f;
            float sliderWidth = position.width - labelWidthStart - labelWidthEnd;

            string myString = EditorGUI.TextField(new Rect(position.x, position.y, labelWidthStart, EditorGUIUtility.singleLineHeight), newMin.ToString("F0"));
            float parsedFloat;
            if (float.TryParse(myString, out parsedFloat))
            {
                newMin = parsedFloat;
            }

            EditorGUI.MinMaxSlider(new Rect(position.x + labelWidthStart, position.y, sliderWidth, EditorGUIUtility.singleLineHeight), ref newMin, ref newMax, range.minLimit, range.maxLimit);

            string myString2 = EditorGUI.TextField(new Rect(position.x + position.width - labelWidthEnd, position.y, labelWidthStart, EditorGUIUtility.singleLineHeight), newMax.ToString("F0"));
            float parsedFloat2;
            if (float.TryParse(myString2, out parsedFloat2))
            {
                newMax = parsedFloat2;
            }

            minValue.intValue = (int)newMin;
            maxValue.intValue = (int)newMax;
        }
    }
#endif
}