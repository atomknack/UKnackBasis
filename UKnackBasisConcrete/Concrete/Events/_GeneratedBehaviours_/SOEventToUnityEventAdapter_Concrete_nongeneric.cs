//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from SOEventToUnityEventAdapter_FromGeneric
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------
using UnityEngine;
using UKnack.Attributes;
using UKnack.Events;
using UKnack.Preconcrete.Events;

using static UnityEngine.InputSystem.InputAction;

namespace UKnack.Concrete.Events
{
    /// <summary>
    /// Subscribes UnityEvent to SOEvent. 
    /// </summary>
    [AddComponentMenu("UKnack/SOEventToUnityEventAdapters/SOEvent_nongeneric_toUnityEvent")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class SOEventToUnityEventAdapter_Concrete_nongeneric : SOEventToUnityEventAdapter
    {
        [SerializeField]
        [ValidReference(typeof(IEvent), nameof(IEvent.Validate))] 
        private SOEvent _subscribedTo;

        protected override IEvent _iEvent => 
            IEvent.Validate(_subscribedTo);
    }
}

