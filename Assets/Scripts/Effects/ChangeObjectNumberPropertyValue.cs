using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectNumberPropertyValue : ChangeObjectPropertyValue
{
    public float oldValue;
    public float newValue;

    public ChangeObjectNumberPropertyValue Init(BreakoutObject o, string p)
    {
        objectToChange = o;
        propertyToChange = p;
        gameObject.name = "ChangeObjectNumberPropertyValue_" + o.gameObject.name + "_" + p;
        return this;
    }
}