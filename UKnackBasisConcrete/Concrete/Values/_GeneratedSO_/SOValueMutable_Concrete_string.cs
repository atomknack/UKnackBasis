//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from Concrete_ValueSO
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------

using UnityEngine;
using UKnack.Values;
using UKnack.Preconcrete.Values;

namespace UKnack.Concrete.Values
{

[CreateAssetMenu(fileName = "SOValue_string", menuName = "UKnack/SOValueMutable/string", order = 110)]
public sealed class SOValueMutable_Concrete_string : SOValueMutable<string>
    {
        [SerializeField] 
        private USetOrDefault<string> _value;

        public override string RawValue { get => _value.Value; protected set => _value.Value = value; }


    }

}
