using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnState : MonoBehaviour
{
    public TurnStates currentTurnState;
    public enum TurnStates
    {
        playerTurn,
        enemyTurn
    }
}
