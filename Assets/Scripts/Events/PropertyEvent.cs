using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyEvent : Event
{
    public BreakoutObject objectThatChanged;
    public string changedPropertyName;
}
