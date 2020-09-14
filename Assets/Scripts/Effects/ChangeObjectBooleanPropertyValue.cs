using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectBooleanPropertyValue : ChangeObjectPropertyValue
{
    public bool oldValue;
    public bool newValue;

    public ChangeObjectBooleanPropertyValue Init(BreakoutObject o, string p)
    {
        objectToChange = o;
        propertyToChange = p;
        gameObject.name = "ChangeObjectBooleanPropertyValue_" + o.gameObject.name + "_" + p;
        return this;
    }
}