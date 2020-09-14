using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectObjectPropertyValue : ChangeObjectPropertyValue
{
    public BreakoutObject oldValue;
    public BreakoutObject newValue;

    public ChangeObjectObjectPropertyValue Init(BreakoutObject o, string p)
    {
        objectToChange = o;
        propertyToChange = p;
        gameObject.name = "ChangeObjectObjectPropertyValue_" + o.gameObject.name + "_" + p;
        return this;
    }
}