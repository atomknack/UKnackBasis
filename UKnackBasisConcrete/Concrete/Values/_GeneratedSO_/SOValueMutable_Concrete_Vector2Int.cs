//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from Concrete_ValueSO
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------

using UnityEngine;
using UKnack.Values;
using UKnack.Preconcrete.Values;

namespace UKnack.Concrete.Values
{

[CreateAssetMenu(fileName = "SOValue_Vector2Int", menuName = "UKnack/SOValueMutable/Vector2Int", order = 110)]
public sealed class SOValueMutable_Concrete_Vector2Int : SOValueMutable<Vector2Int>
    {
        [SerializeField] 
        private USetOrDefault<Vector2Int> _value;

        public override Vector2Int RawValue { get => _value.Value; protected set => _value.Value = value; }


    }

}