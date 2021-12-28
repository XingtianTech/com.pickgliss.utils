using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.Extension
{
    public static class UtilityExtensions
    {
        /// <summary>
        /// Gets the components only in immediate children of parent.
        /// </summary>
        /// <returns>The components only in children.</returns>
        /// <param name="script">MonoBehaviour Script, e.g. "this".</param>
        /// <param name="isRecursive">If set to <c>true</c> recursive search of children is performed.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T[] GetComponentsOnlyInChildren<T>(this UnityEngine.MonoBehaviour script, bool isRecursive = false) where T : class
        {
            if (isRecursive)
                return script.GetComponentsOnlyInChildren_Recursive<T>();
            return script.GetComponentsOnlyInChildren_NonRecursive<T>();
        }

        /*
    /// <summary>
    /// Gets the components only in children, with interface check. Slowest recursive check.
    /// </summary>
    /// <returns>The components only in children that are either interface, 
    /// component or subclass of a component passed.</returns>
    /// <param name="script">Script.</param>
    /// <typeparam name="T">The 1st type parameter.</typeparam>
    static T[] GetComponentsOnlyInChildren_Interface<T>(this MonoBehaviour script) where T : class
    {
        List<T> group = new List<T>();
        //collect only if its an interface or a Component
        if (typeof(T).IsInterface || typeof(T).IsSubclassOf(typeof(Component))
        || typeof(T) == typeof(Component))
        {
            foreach (Transform child in script.transform)
            {
                group.AddRange(child.GetComponentsInChildren<T>());
            }
        }
        return group.ToArray();
    }
    */

        /// <summary>
        /// Gets the components only in children transform search. Not recursive, ie not grandchildren! 
        /// </summary>
        /// <returns>The components only in children transform search.</returns>
        /// <param name="parent">Parent, ie "this".</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        static T[] GetComponentsOnlyInChildren_NonRecursive<T>(this UnityEngine.MonoBehaviour parent) where T : class
        {
            if (parent.transform.childCount <= 0) return null;

            var output = new List<T>();

            for (int i = 0; i < parent.transform.childCount; i++)
            {
                var component = parent.transform.GetChild(i).GetComponent<T>();
                if (component != null)
                    output.Add(component);
            }
            if (output.Count > 0)
                return output.ToArray();

            return null;
        }

        /// <summary>
        /// Gets the components only in children, recursively for children of children.
        /// </summary>
        /// <returns>The components only in children of calling parent.</returns>
        /// <param name="parent">Parent.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        static T[] GetComponentsOnlyInChildren_Recursive<T>(this UnityEngine.MonoBehaviour parent) where T : class
        {
            if (parent.transform.childCount <= 0) return null;

            var transforms = new HashSet<Transform>(parent.GetComponentsInChildren<Transform>());
            transforms.Remove(parent.transform);

            var output = new List<T>();
            foreach (var child in transforms)
            {
                var component = child.GetComponent<T>();
                if (component != null)
                {
                    output.Add(component);
                }
            }

            if (output.Count > 0)
                return output.ToArray();

            return null;
        }

        /* This is still fastest...
     * 
     foreach (var i in GetComponentsInChildren<INotify>()
     {
        if (i == GetComponent<INotify>()) continue;
        i.Notify();
     }
     * 
     */
    }
}