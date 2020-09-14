using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPropertyChanged : PropertyEvent
{
    public float oldValue;
    public float newValue;

    public NumberPropertyChanged Init(BreakoutObject o, string p)
    {
        objectThatChanged = o;
        changedPropertyName = p;
        gameObject.name = "NumberPropertyChanged_" + o.gameObject.name + "_" + p;
        return this;
    }
}