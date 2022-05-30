using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class NumberCounterUpdater : MonoBehaviour
{
    public NumberCounter NumberCounter;
    public TMP_InputField InputField;

    public void SetValue()
    {
        int value;

        if (int.TryParse(InputField.text, out value))
        {
            NumberCounter.Value = value;
        }
    }
}