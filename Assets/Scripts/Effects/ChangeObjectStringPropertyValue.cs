using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectStringPropertyValue : ChangeObjectPropertyValue
{
    public string oldValue;
    public string newValue;

    public ChangeObjectStringPropertyValue Init(BreakoutObject o, string p)
    {
        objectToChange = o;
        propertyToChange = p;
        gameObject.name = "ChangeObjectStringPropertyValue_" + o.gameObject.name + "_" + p;
        return this;
    }
}