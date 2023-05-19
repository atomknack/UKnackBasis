using System.Collections;
using System.Collections.Generic;
using UKnack.Attributes;
using UnityEngine;

public class MarkAsColorExample : MonoBehaviour
{
    [SerializeField]
    [MarkNullAsColor(0.7f, 0.7f, 0.1f)]
    GenericBehaviour<int> _genericInt1;

    [SerializeField]
    [DisableEditingInPlaymode]
    [MarkNullAsColor(0.5f,0.5f,0.1f)]
    GenericBehaviour<int> _genericInt2DisabledBefore;


    [SerializeField]
    [MarkNullAsColor(0.35f, 0.35f, 0.1f)]
    [DisableEditingInPlaymode]
    GenericBehaviour<int> _genericInt3DisabledAfter;

    [SerializeField]
    [MarkNullAsPurple]
    GenericBehaviour<int> _genericInt4MarkNullAsPurple;
}
