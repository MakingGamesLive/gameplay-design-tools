using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBooleanValueChanged : GameEvent
{
    public BooleanValue booleanValue;
    public bool oldValue;
    public bool newValue;

    public GameBooleanValueChanged Init(BooleanValue n)
    {
        booleanValue = n;
        gameObject.name = n.gameObject.name + "BooleanValueChanged";
        return this;
    }
}
