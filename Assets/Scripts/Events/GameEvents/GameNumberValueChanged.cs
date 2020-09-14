using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameNumberValueChanged : GameEvent
{
    public NumberValue numberValue;
    public float oldValue;
    public float newValue;

    public GameNumberValueChanged Init(NumberValue n)
    {
        numberValue = n;
        gameObject.name = n.gameObject.name+"NumberValueChanged";
        return this;
    }
}
