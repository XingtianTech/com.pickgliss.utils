using System.Collections.Generic;

namespace Pickgliss.SOA.Collections
{
    public class Library<T> : Collection<T> where T : UnityEngine.Object
    {
        public string[] labels;
        public List<string> searchInFolders = new();

#if UNITY_EDITOR
        protected string GetFilterString()
        {
            if (labels == null) return "t:" + typeof(T).Name;
            var result = "";
            foreach (var label in labels)
            {
                result += "l:"+label+" ";
            }
            result += "t:" + typeof(T).Name;
            return result;
        }

        protected void GarbObjects()
        {
            var filterString = GetFilterString();
            string[] guids;
            if (searchInFolders.Count > 0)
            {
                guids = UnityEditor.AssetDatabase.FindAssets (filterString,searchInFolders.ToArray());
            }
            else
            {
                guids = UnityEditor.AssetDatabase.FindAssets(filterString);
            }

            items ??= new List<T>();
            items.Clear();
            foreach (var guid in guids)
            {
                var path = UnityEditor.AssetDatabase.GUIDToAssetPath (guid);
                var item = UnityEditor.AssetDatabase.LoadAssetAtPath<T> (path);
                items.Add(item);
                UnityEditor.EditorUtility.SetDirty(this);
            }
        }
#endif
    }
}