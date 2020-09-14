using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameNumberValue : Effect
{
    public NumberValue valueToChange;
    public float newValue;

    public ChangeGameNumberValue Init(NumberValue n)
    {
        valueToChange = n;
        gameObject.name = "ChangeGameNumberValue" + n.gameObject.name;
        return this;
    }
}
