using Pickgliss.SOA.Variables;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

// IngredientDrawerUIE
[CustomPropertyDrawer(typeof(VariableMappingEntry<float>))]
[CustomPropertyDrawer(typeof(VariableMappingEntry<int>))]
public class FloatMappingEntryDrawer : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        VisualTreeAsset vta = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Packages/com.pickgliss.utils/Editor/Assets/FloatMappingEntry.uxml");
        // VisualElement ve = vta.CloneTree();
        VisualElement ve = vta.CloneTree(property.propertyPath);
        return ve;
    }
}