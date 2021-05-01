using UnityEngine;
namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = ByteVariable.Name,menuName = SOASetting.SOA_Value + ByteVariable.Name,order = 0)]
    public class ByteVariable : NumericVariable<byte>
    {
        public const string Name = "Byte";
    }
}