using System;
using System.IO;
using UnityEngine;

namespace Pickgliss.Helper
{
    public static class StringHelper
    {
        public static string AssetsFolder => Application.dataPath;
        public static string ResolveAssetPath(string assetPath) => Path.GetFullPath($"{AssetsFolder}/../{assetPath}");
        public static string FullPathToRelative( string absolutepath)
        {
            var relativepath = "";
            if (absolutepath.StartsWith(Application.dataPath)) {
                relativepath=  "Assets" + absolutepath.Substring(Application.dataPath.Length);
            }

            return relativepath;
        }

        public const string ResourcePath = "Assets/Resources/";

        public static string AssetPathToResourcePath(string absolutepath)
        {
            var resource = absolutepath;
            if (resource.StartsWith(ResourcePath))
            {
                resource = absolutepath.Substring(ResourcePath.Length);
            }
            return resource;
        }
        
        public static string FileNameFromUrl(string url)
        {
            var uri = new Uri(url);
            var fileName=  Path.GetFileName(uri.AbsolutePath);
            return fileName;
        }

        public static string AssetDatabasePathFromAbsolute(string absolute)
        {
            var absoluteUnixStyle = absolute.Replace("\\", "/");
            Debug.Assert(absoluteUnixStyle.StartsWith(AssetsFolder));
            return absoluteUnixStyle.Replace(AssetsFolder, "Assets");
        }
    }
}