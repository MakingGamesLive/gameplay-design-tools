using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : Effect
{
    public BreakoutObject objectToSpawn;

    public SpawnObject Init(BreakoutObject b)
    {
        objectToSpawn = b;
        gameObject.name = "Spawn"+b.gameObject.name;
        return this;
    }
}
