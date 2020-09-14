using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringPropertyChanged : PropertyEvent
{
    public string oldValue;
    public string newValue;

    public StringPropertyChanged Init(BreakoutObject o, string p)
    {
        objectThatChanged = o;
        changedPropertyName = p;
        gameObject.name = "StringPropertyChanged_" + o.gameObject.name + "_" + p;
        return this;
    }
}
