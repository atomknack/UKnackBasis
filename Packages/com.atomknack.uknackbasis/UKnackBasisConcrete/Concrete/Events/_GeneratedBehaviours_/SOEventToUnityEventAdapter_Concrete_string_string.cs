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
    [AddComponentMenu("UKnack/SOEventToUnityEventAdapters/SOEvent_string_string_toUnityEvent")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class SOEventToUnityEventAdapter_Concrete_string_string : SOEventToUnityEventAdapter<string,string>
    {
        [SerializeField]
        [ValidReference(typeof(IEvent<string,string>), nameof(IEvent<string,string>.Validate))] 
        private SOEvent<string,string> _subscribedTo;

        protected override IEvent<string,string> _iEvent => 
            IEvent<string,string>.Validate(_subscribedTo);
    }
}

