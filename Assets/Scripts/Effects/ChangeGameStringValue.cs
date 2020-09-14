using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameStringValue : Effect
{
    public StringValue valueToChange;
    public string newValue;

    public ChangeGameStringValue Init(StringValue s)
    {
        valueToChange = s;
        gameObject.name = "ChangeGameStringValue" + s.gameObject.name;
        return this;
    }
}
