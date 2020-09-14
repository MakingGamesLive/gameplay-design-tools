using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObject : Effect
{
    public BreakoutObject objectToDespawn;

    public DespawnObject Init(BreakoutObject b)
    {
        objectToDespawn = b;
        gameObject.name = "Despawn" + b.gameObject.name;
        return this;
    }
}
