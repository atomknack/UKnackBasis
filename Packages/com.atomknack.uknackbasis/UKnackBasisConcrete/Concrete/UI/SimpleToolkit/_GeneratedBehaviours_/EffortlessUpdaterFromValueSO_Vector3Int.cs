//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from EffortlessUpdaterFromValueSO
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------

using UnityEngine;
using System.ComponentModel;
using UKnack.Attributes;
using UKnack.Values;
using UKnack.Preconcrete.UI.SimpleToolkit;

namespace UKnack.UI
{

    [AddComponentMenu("UKnack/UI.SimpleToolkit/EffortlessUpdaterFromValueSO/Vector3Int")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public sealed class EffortlessUpdaterFromValueSO_Vector3Int : EffortlessUpdaterFromValueSO<Vector3Int>
    {
        [SerializeField][ValidReference(nameof(ValidIValue))] private SOValue<Vector3Int> _value;

        protected override IValue<Vector3Int> GetValidValueProvider() 
            => ValidIValue(_value);

        protected override string RawValueToStringConversion(Vector3Int value)
            => value.ToString();
    

        public static IValue<Vector3Int> ValidIValue(UnityEngine.Object value)
        {
            if (value==null)
                throw new System.ArgumentNullException(nameof(value));
            var asIValue = value as IValue<Vector3Int>;
            if (asIValue == null)
                throw new System.InvalidCastException($"{value.GetType()} is not compatible with {typeof(IValue<Vector3Int>)}");
            return asIValue;
        }
    }
}

