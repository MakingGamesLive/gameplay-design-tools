using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpritePropertyChanged : PropertyEvent
{
    public ObjectSprite oldValue;
    public ObjectSprite newValue;

    public ObjectSpritePropertyChanged Init(BreakoutObject o, string p)
    {
        objectThatChanged = o;
        changedPropertyName = p;
        gameObject.name = "ObjectSpritePropertyChanged_" + o.gameObject.name + "_" + p;
        return this;
    }
}
