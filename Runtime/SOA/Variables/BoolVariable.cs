using UnityEngine;
namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = BoolVariable.Name,menuName = SOASetting.SOA_Value + BoolVariable.Name,order = 0)]
    public class BoolVariable : NumericVariable<bool>
    {
        public const string Name = "Bool";
    }
}