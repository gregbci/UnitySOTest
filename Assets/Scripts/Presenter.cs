using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    // contains a bunch of Counters
    public Settings settings;

    // one particular Counter to mess with
    public Counter counter;

    public TMP_Text counterText;

    public void Start()
    {
        Debug.Log("Presenter: found " + settings.counters.Count + " counters in settings:");
        settings.counters.ForEach(counter => Debug.Log(counter.countName));
    }

    public void IncrementCounter()
    {
        // change the game object
        counter.count++;

        // change the text
        counterText.text = counter.count.ToString();
    }
}
