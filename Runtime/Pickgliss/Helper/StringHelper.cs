using UnityEngine;

namespace Pickgliss.Helper
{
    public static class StringHelper
    {
        public static string FullPathToRelative( string absolutepath)
        {
            var relativepath = "";
            if (absolutepath.StartsWith(Application.dataPath)) {
                relativepath=  "Assets" + absolutepath.Substring(Application.dataPath.Length);
            }

            return relativepath;
        }
    }
}