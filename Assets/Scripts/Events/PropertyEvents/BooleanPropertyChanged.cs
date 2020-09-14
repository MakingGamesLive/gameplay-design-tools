using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanPropertyChanged : PropertyEvent
{
    public bool oldValue;
    public bool newValue;

    public BooleanPropertyChanged Init(BreakoutObject o, string p)
    {
        objectThatChanged = o;
        changedPropertyName = p;
        gameObject.name = "BooleanPropertyChanged_" + o.gameObject.name + "_" + p;
        return this;
    }
}
