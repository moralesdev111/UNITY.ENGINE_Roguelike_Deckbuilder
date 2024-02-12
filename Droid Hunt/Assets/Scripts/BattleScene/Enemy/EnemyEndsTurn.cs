using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEndsTurn : MonoBehaviour
{
    [SerializeField] TurnManager turnManager;
    [SerializeField] EnemyAttack enemyAttack;
    public bool hasEndedTurn = false;

    private void Update()
    {
        StartCoroutine(EndEnemyTurn());
    }

     IEnumerator EndEnemyTurn()
    {
        yield return new WaitUntil(() => enemyAttack.hasAttacked); // Wait until enemy has attacked
        yield return new WaitForSeconds(1.5f);
        EndTurn();
        GameManager.Instance.UpdateGameState(GameManager.GameState.playerTurn);
    }

    private void EndTurn()
    {
        if (!hasEndedTurn)
        {
            turnManager.EndEnemyTurn();
            hasEndedTurn = true;
        }
}
}