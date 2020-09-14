using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDespawned : GameEvent
{
    public BreakoutObject objectDespawned;

    public ObjectDespawned Init(BreakoutObject b)
    {
        objectDespawned = b;
        gameObject.name =b.gameObject.name + "Despawned";
        return this;
    }
}
