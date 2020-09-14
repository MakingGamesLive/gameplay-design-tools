using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameBooleanValue : Effect
{
    public BooleanValue valueToChange;
    public bool newValue;

    public ChangeGameBooleanValue Init(BooleanValue b)
    {
        valueToChange = b;
        gameObject.name = "ChangeGameBooleanValue" + b.gameObject.name;
        return this;
    }
}
