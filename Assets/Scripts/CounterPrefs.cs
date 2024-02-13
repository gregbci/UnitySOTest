using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CounterPrefs is just a dummy "preferences" object to test setting management
// within in a Unity application.

// this will create a CounterPrefs for at the top of the create menu to add
// an instance of the CounterPrefs ScriptableObject.
[CreateAssetMenu]
public class CounterPrefs : ScriptableObject
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
