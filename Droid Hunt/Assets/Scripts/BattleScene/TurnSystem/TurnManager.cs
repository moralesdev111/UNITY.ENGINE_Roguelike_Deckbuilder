using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    [SerializeField] TurnLogistics turnSettings;

    void Start()
    {
        turnSettings.InitialTurnSettings();
    }
    

    public void EndPlayerTurn()
    {
        if(turnSettings.isPlayerTurn)
        {
           turnSettings.EndYourTurn();
        }
    }

    public void EndOpponentTurn()
    {
        if(!turnSettings.isPlayerTurn)
        {
            turnSettings.EndEnemyTurn();
        }
    }
}
