using Pickgliss.Collections;

namespace Pickgliss.SOA.Collections
{
    public class Labeled<T> : Collection<T> where T : UnityEngine.Object
    {
        public string[] labels;

#if UNITY_EDITOR
        protected virtual string GetFilterString()
        {
            var result = "";
            foreach (var label in labels)
            {
                result += "l:"+label+" ";
            }
            // result += "t:" + typeof(T).Name;
            return result;
        }
        protected virtual void OnValidate()
        {
            var filterString = GetFilterString();
            var guids = UnityEditor.AssetDatabase.FindAssets (filterString);
            items.Clear();
            for(var i = 0; i < guids.Length; i++)
            {
                var path = UnityEditor.AssetDatabase.GUIDToAssetPath (guids [i]);
                var item = UnityEditor.AssetDatabase.LoadAssetAtPath<T> (path);
                items.Add(item);
                UnityEditor.EditorUtility.SetDirty(this);
            }
        }
#endif
    }
}