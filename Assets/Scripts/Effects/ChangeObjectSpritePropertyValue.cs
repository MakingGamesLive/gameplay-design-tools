using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectSpritePropertyValue : ChangeObjectPropertyValue
{
    public ObjectSprite oldValue;
    public ObjectSprite newValue;

    public ChangeObjectSpritePropertyValue Init(BreakoutObject o, string p)
    {
        objectToChange = o;
        propertyToChange = p;
        gameObject.name = "ChangeObjectSpritePropertyValue_" + o.gameObject.name + "_" + p;
        return this;
    }
}