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
    [AddComponentMenu("UKnack/SOEventToUnityEventAdapters/SOEvent_Vector2_toUnityEvent")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal sealed class SOEventToUnityEventAdapter_Concrete_Vector2 : SOEventToUnityEventAdapter<Vector2>
    {
        [SerializeField]
        [ValidReference(typeof(IEvent<Vector2>), nameof(IEvent<Vector2>.Validate))] 
        private SOEvent<Vector2> _subscribedTo;

        protected override IEvent<Vector2> _iEvent => 
            IEvent<Vector2>.Validate(_subscribedTo);
    }
}

