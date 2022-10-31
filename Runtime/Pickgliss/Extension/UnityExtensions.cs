using Pickgliss.Extension;
using System.Reflection;
using System;
using UnityEngine;
 using UnityEngine.Events;
 
 public static class UnityExtensions{
 
 /// <summary>
     /// Extension method to check if a layer is in a layermask
     /// </summary>
     /// <param name="mask"></param>
     /// <param name="layer"></param>
     /// <returns></returns>
     public static bool Contains(this LayerMask mask, int layer)
     {
         return mask == (mask | (1 << layer));
     }

    /// <summary>
    /// Will get the string value for a given enums value, this will
    /// only work if you assign the StringValue attribute to
    /// the items in your enum.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetStringValue(this Enum value)
    {
        // Get the type
        Type type = value.GetType();

        // Get fieldinfo for this type
        FieldInfo fieldInfo = type.GetField(value.ToString());

        // Get the stringvalue attributes
        StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
            typeof(StringValueAttribute), false) as StringValueAttribute[];

        // Return the first if there was a match.
        return attribs.Length > 0 ? attribs[0].StringValue : null;
    }
}