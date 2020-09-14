using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair : MonoBehaviour
{
    public Event _event;
    public Effect _effect;

    public Pair Init(Event e, Effect f)
    {
        _event = e;
        _effect = f;
        gameObject.name = "Pair_" + e.gameObject.name + "_" + f.gameObject.name;
        return this;
    }
}
