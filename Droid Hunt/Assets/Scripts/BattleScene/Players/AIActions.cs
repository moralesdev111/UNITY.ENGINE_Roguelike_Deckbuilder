using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIActions : MonoBehaviour
{
    [SerializeField] EnemyRobot enemyRobot;
    [SerializeField] Player player;
    public bool hasAttacked = false;

    void OnEnable()
    {
        GameManager.onGameStateChanged += EnemyAttacks;
    }

    void OnDisable()
    {
        GameManager.onGameStateChanged -= EnemyAttacks;
    }


    public void EnemyAttacks(GameManager.GameState newState)
    {
        if(newState == GameManager.GameState.enemyTurn && !hasAttacked)
        {
            player.currentParts -= enemyRobot.attack;
            hasAttacked = true;
        }
    }
}
