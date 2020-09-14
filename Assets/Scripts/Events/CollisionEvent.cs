using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : Event
{
    public BreakoutObject firstObject;
    public BreakoutObject secondObject;

    public CollisionEvent Init(BreakoutObject a,BreakoutObject b)
    {
        firstObject = a;
        secondObject = b;
        gameObject.name = "Collision_" + a.name + "_" + b.name;
        return this;
    }
}
