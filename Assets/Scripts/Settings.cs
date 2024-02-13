using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Settings : ScriptableObject
{
    // Maintain a list of counters
    [Tooltip("The list of counter objects")]
    public List<Counter> counters = new List<Counter>();
}
