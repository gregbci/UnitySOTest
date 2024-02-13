using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Counter : ScriptableObject
{
    [Tooltip("The counter")]
    [Range(0, 100)]
    public int count = 0;
}
