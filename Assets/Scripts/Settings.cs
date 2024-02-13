using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Settings : ScriptableObject
{
    // Maintain a list of counters
    [Tooltip("The list of counter objects")]
    public List<CounterPrefs> counters = new List<CounterPrefs>();

    // Convert class to Json string
    public string ToJson()
    {
        return JsonUtility.ToJson(this);
    }

    // Fill in class from Json string
    public void LoadFromJson(string a_Json)
    {
        JsonUtility.FromJsonOverwrite(a_Json, this);
    }
}
