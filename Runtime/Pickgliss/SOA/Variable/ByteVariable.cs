using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = ByteVariable.Name,menuName = SOASetting.SOA_Value + ByteVariable.Name,order = 0)]
    public class ByteVariable : Variable<byte>
    {
        public const string Name = "Byte";
    }
}