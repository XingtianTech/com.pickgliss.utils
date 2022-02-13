using System;
using System.IO;
using UnityEngine;

namespace Pickgliss.Helper
{
    public static class PathHelper
    {
        public static string AssetsFolder => Application.dataPath;
        public static string ResolveAssetPath(string assetPath) => Path.GetFullPath($"{AssetsFolder}/../{assetPath}");
        public static string FullPathToRelative( string absolutePath)
        {
            var relativePath = "";
            if (absolutePath.StartsWith(Application.dataPath)) {
                relativePath=  "Assets" + absolutePath.Substring(Application.dataPath.Length);
            }

            return relativePath;
        }

        public const string ResourcePath = "Assets/Resources/";

        public static string AssetPathToResourcePath(string absolutePath)
        {
            var resource = absolutePath;
            if (resource.StartsWith(ResourcePath))
            {
                resource = absolutePath.Substring(ResourcePath.Length);
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