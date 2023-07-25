//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from SOValueToUnityEventAdapter_FromGeneric
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.Events;
using UKnack.Preconcrete.Commands;
using UKnack.Attributes;
using UKnack.Events;
using UKnack.Values;

using static UnityEngine.InputSystem.InputAction;

namespace UKnack.Concrete.Values
{
    /// <summary>
    /// Subscribes UnityEvent to SOValue. 
    /// And in OnEnable invokes UnityEvent with SOValue (Unlike SOEvent version of such script, that only waits for event).
    /// </summary>
    [AddComponentMenu("UKnack/SOValueToUnityEventAdapters/SOValue_Vector3_toUnityEvent")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class SOValueToUnityEventAdapter_Concrete_Vector3 : AbstractCommandSubscribedToSOEvent<Vector3>
    {
        [SerializeField]
        [ValidReference(typeof(IEvent<Vector3>), nameof(IEvent<Vector3>.Validate))] 
        private SOEvent<Vector3> _subscribedTo;

        [SerializeField]
        private UnityEvent<Vector3> _unityEvent;

        [SerializeField]
        [Tooltip("Subscribes UnityEvent to SOValue, OnEnable invokes UnityEvent with value of SOValue")]
        [ValidReference(typeof(IValue<Vector3>), nameof(IValue<Vector3>.Validate))] 
        private SOValue<Vector3> _value;

        private new void OnEnable()
        {
            base.OnEnable();
            _unityEvent?.Invoke(_value.GetValue());
        }

        protected override IEvent<Vector3> SubscribedTo => 
            IEvent<Vector3>.Validate(_subscribedTo);

        public override void Execute(Vector3 v) => 
            _unityEvent?.Invoke(v);
    }
}

