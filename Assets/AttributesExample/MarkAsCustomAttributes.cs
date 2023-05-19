using System.Collections;
using System.Collections.Generic;
using UKnack.Attributes;
using UKnack.Attributes.KnackAttributeDrawers;
using UnityEditor;
using UnityEngine;


public class MarkNullAsPurpleAttribute : MarkNullAsColorAttribute
{
    public MarkNullAsPurpleAttribute() : 
        base(0.4f, 0, 0.55f, "Property should NOT be null")
    {
    }
}


#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(MarkNullAsPurpleAttribute))]
public class MarkNullAsPurpleAttributeDrawer : MarkNullAsColorAttributeDrawer
{

}
#endif