using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
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
            StartCoroutine(DelayAttackStart());
        }
    }

    IEnumerator DelayAttackStart()
    {
        yield return new WaitForSeconds(1f);
        player.currentParts -= enemyRobot.attack;
        if (player.currentParts <= 0)
        {
            GameManager.Instance.UpdateGameState(GameManager.GameState.finishScreen);
        }
        hasAttacked = true;
    }
}
