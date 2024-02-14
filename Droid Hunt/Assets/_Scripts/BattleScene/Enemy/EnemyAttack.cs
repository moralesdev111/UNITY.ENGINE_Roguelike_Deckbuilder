using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] EnemyInstance enemyInstance;
    [SerializeField] Player player;
    public bool hasAttacked = false;

    void OnEnable()
    {
        SceneManager.onGameStateChanged += EnemyAttacks;
    }

    void OnDisable()
    {
        SceneManager.onGameStateChanged -= EnemyAttacks;
    }


    public void EnemyAttacks(SceneManager.GameState newState)
    {
        if(newState == SceneManager.GameState.enemyTurn && !hasAttacked)
        {
            StartCoroutine(DelayAttackStart());
        }
    }

    IEnumerator DelayAttackStart()
    {
        yield return new WaitForSeconds(1f);
        player.currentParts -= enemyInstance.enemyToFace.enemyRobot.attack;
        if (player.currentParts <= 0)
        {
            SceneManager.Instance.UpdateGameState(SceneManager.GameState.finishScreen);
        }
        hasAttacked = true;
    }
}
