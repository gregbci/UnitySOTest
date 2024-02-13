using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    public Counter counter;

    public TMP_Text counterText;

    public void IncrementCounter()
    {
        // change the game object
        counter.count++;

        // change the text
        counterText.text = counter.count.ToString();
    }
}
