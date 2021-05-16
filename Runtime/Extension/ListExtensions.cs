using System.Collections.Generic;
using Pickgliss.Helper;
using Unity.Mathematics;

public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list,Random random)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = random.NextInt(n + 1);  
            T value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    }
}