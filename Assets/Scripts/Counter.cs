using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this will create an entry "Counter" at the top of the create menu to add
// an instance of the Counter ScriptableObject.
[CreateAssetMenu]
public class Counter : ScriptableObject
{
    [Tooltip("The counter")]
    [Range(0, 100)]
    public int count = 0;
}
