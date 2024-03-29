//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from SOEventToUnityEventAdapter_FromGeneric
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.Events;
using UKnack.Attributes;
using UKnack.Events;
using UKnack.Preconcrete.Commands;

using static UnityEngine.InputSystem.InputAction;

namespace UKnack.Concrete.Events
{
    /// <summary>
    /// Subscribes UnityEvent to SOEvent. 
    /// </summary>
    [AddComponentMenu("UKnack/SOEventToUnityEventAdapters/SOEvent_int_toUnityEvent")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class SOEventToUnityEventAdapter_Concrete_int : AbstractCommandSubscribedToSOEvent<int>
    {
        [SerializeField]
        [ValidReference(typeof(IEvent<int>), nameof(IEvent<int>.Validate))] 
        private SOEvent<int> _subscribedTo;

        [SerializeField]
        private UnityEvent<int> _unityEvent;

        protected override IEvent<int> SubscribedTo => 
            IEvent<int>.Validate(_subscribedTo);

        public override void Execute(int t) => 
            _unityEvent?.Invoke(t);

    }
}

