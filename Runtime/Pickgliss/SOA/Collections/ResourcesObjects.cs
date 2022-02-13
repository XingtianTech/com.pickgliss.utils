﻿using System.Collections.Generic;
using Pickgliss.Helper;
using Pickgliss.SOA.Editor;
using UnityEditor;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    [CreateAssetMenu(fileName = "ResourcesObjects",menuName = "Collection/Resources Objects")]
    public class ResourcesObjects :  ResourceFolder<GameObject>
    {
        
    }
    
    public class ResourceFolder<T> : Collection<T> where T : Object
    {
        public FolderReference folder;

        private void Awake()
        {
            Update();
        }

        public void OnValidate()
        {
            Update();
        }

        public void Update()
        {
            var resourcePath = StringHelper.AssetPathToResourcePath(folder.Path);
            items ??= new List<T>();
            items.Clear();
            var res = Resources.LoadAll<T>(resourcePath);
            items.AddRange(res);
            EditorUtility.SetDirty(this);
        }
    }
}