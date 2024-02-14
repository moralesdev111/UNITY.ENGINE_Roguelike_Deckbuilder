using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance;
    public PlayerHand playerHand;
    public Player player;
    public EnemyInstance enemy;
    public GameState currentGameState;
    public static event Action<GameState> onGameStateChanged;
    [SerializeField] EnemyAttack aIActions;
    [SerializeField] EnemyEndsTurn enemyEndsTurn;
    [SerializeField] BattleManager battleManager;



    void Awake()
{
     if (!Instance)
     {
        Instance = this;
     }
     else
     {
          //Duplicate GameManager created every time the scene is loaded
        Destroy(gameObject);
     }
}


    void Start()
    {
        UpdateGameState(GameState.playerTurn);
    }

    public void UpdateGameState(GameState newState)
    {
        currentGameState = newState;

        switch(newState)
        {
            case GameState.playerTurn:
            aIActions.hasAttacked = false;
            enemyEndsTurn.hasEndedTurn = false;
            break;

            case GameState.enemyTurn:
            break;

            case GameState.finishScreen:
            if (player.currentParts <= 0)
            {
                battleManager.Defeat();
            }
            else if(enemy.currentParts <= 0)
            {
                battleManager.Victory();
            }
            break;
        }
    onGameStateChanged?.Invoke(newState);
    }


    public enum GameState
    {
        playerTurn,
        enemyTurn,
        finishScreen,
    }
}
