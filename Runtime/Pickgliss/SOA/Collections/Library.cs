namespace Pickgliss.SOA.Collections
{
    public class Library<T> : Collection<T> where T : UnityEngine.Object
    {
        public string[] labels;
        public string[] searchInFolders;

#if UNITY_EDITOR
        protected string GetFilterString()
        {
            var result = "";
            foreach (var label in labels)
            {
                result += "l:"+label+" ";
            }
            result += "t:" + typeof(T).Name;
            return result;
        }

        protected virtual void OnValidate()
        {
            var filterString = GetFilterString();
            var guids = UnityEditor.AssetDatabase.FindAssets (filterString,searchInFolders);
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