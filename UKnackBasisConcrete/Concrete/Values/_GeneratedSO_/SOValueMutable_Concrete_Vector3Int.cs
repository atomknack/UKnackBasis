//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from Concrete_ValueSO
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------

using UnityEngine;
using UKnack.Values;
using UKnack.Preconcrete.Values;

namespace UKnack.Concrete.Values
{

[CreateAssetMenu(fileName = "SOValue_Vector3Int", menuName = "UKnack/SOValueMutable/Vector3Int", order = 110)]
public sealed class SOValueMutable_Concrete_Vector3Int : SOValueMutable<Vector3Int>
    {
        [SerializeField] 
        private USetOrDefault<Vector3Int> _value;

        public override Vector3Int RawValue { get => _value.Value; protected set => _value.Value = value; }


    }

}