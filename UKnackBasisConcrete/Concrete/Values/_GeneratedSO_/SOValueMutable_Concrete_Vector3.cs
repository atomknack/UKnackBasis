//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from Concrete_ValueSO
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------

using UnityEngine;
using UKnack.Values;
using UKnack.Preconcrete.Values;

namespace UKnack.Concrete.Values
{

[CreateAssetMenu(fileName = "SOValue_Vector3", menuName = "UKnack/SOValueMutable/Vector3", order = 110)]
public sealed class SOValueMutable_Concrete_Vector3 : SOValueMutable<Vector3>
    {
        [SerializeField] 
        private USetOrDefault<Vector3> _value;

        public override Vector3 RawValue { get => _value.Value; protected set => _value.Value = value; }


    }

}
