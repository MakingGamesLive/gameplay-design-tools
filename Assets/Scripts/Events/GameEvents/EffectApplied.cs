using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectApplied : GameEvent
{
    public Effect effect;

    public EffectApplied Init(Effect e)
    {
        effect = e;
        gameObject.name = e.gameObject.name+"EffectApplied";
        return this;
    }
}
