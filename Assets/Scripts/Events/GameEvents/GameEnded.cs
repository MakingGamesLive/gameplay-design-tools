using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnded : GameEvent
{
    public bool playerWon;

    public GameEnded Init(bool b)
    {
        playerWon = b;
        gameObject.name = (b ? "playerWon" : "playerLost");
        return this;
    }
}
