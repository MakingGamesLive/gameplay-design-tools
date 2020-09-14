using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStringValueChanged : GameEvent
{
    public StringValue stringValue;
    public string oldValue;
    public string newValue;

    public GameStringValueChanged Init(StringValue n)
    {
        stringValue = n;
        gameObject.name = n.gameObject.name + "StringValueChanged";
        return this;
    }
}
