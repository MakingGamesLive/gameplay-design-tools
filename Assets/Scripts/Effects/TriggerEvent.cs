using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : Effect
{
    public Event eventToTrigger;

    public TriggerEvent Init(Event e)
    {
        eventToTrigger = e;
        gameObject.name = "Trigger"+e.gameObject.name;
        return this;
    }
}
