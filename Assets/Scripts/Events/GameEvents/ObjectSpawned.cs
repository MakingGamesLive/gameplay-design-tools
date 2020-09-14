using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawned : GameEvent
{
    public BreakoutObject objectSpawned;

    public ObjectSpawned Init(BreakoutObject b)
    {
        objectSpawned = b;
        gameObject.name = b.gameObject.name+"Spawned";
        return this;
    }
}
