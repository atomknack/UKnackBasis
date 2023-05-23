using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestScriptableObject", menuName = "UKnackTest/TestScriptableObject", order = 110)]
public class TestScriptableObject : ScriptableObject, ITest
{
    public void Test()
    {
        throw new System.NotImplementedException();
    }
}
