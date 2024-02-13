using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this will create an entry "Counter" at the top of the create menu to add
// an instance of the Counter ScriptableObject.
[CreateAssetMenu]
public class Counter : ScriptableObject
{
    // Use this to test accesing a list of Counters from another ScriptableObject
    [Tooltip("Counter name")]
    public string countName = "";

    // Have an object increment this and another one display it
    [Tooltip("The counter")]
    [Range(0, 100)]
    public int count = 0;

    // A list appears in the editor with a +/- button to add instances of things
    [Tooltip("The counter's history list")]
    public List<int> history = new List<int>();
}
