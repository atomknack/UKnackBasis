//----------------------------------------------------------------------------------------
// <auto-generated> This code was generated from Concrete_SOEventS
// Changes will be lost if the code is regenerated.</auto-generated>
//----------------------------------------------------------------------------------------
using System;
using UnityEngine;
using UKnack.Attributes;
using UKnack.Values;

using static UnityEngine.InputSystem.InputAction;

namespace UKnack.Concrete.Events
{
    /// This class not intended to be used in code, but only made for ease of creation scriptable object in Unity Editor
    [CreateAssetMenu(fileName = "ConditionalPublisherToSOEvent_CallbackContext ", menuName = "UKnack/ConditionalPublishers/To CallbackContext")]
    internal sealed class SOConditionalPublisher_Concrete_CallbackContext : SOPublisher_Concrete_CallbackContext
    {
            [Tooltip("This publisher will publish only when this value is true, if value is false publish call will be silently ignored")]
            [SerializeField] 
            [ValidReference(typeof(IValue<bool>), nameof(IValue<bool>.Validate))] 
           private SOValue<bool> publishWhenTrue;
            public override void Publish(CallbackContext ctx)
            {
               IValue<bool>.Validate(publishWhenTrue);
               if (publishWhenTrue.GetValue() == false)
                   return;
              base.Publish(ctx);
            }
    }
}
